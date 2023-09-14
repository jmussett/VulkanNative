using VulkanNative.Examples.Common.Glfw;
using VulkanNative.Examples.Common;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.HelloTriangle;

internal class HelloTriangle
{
    private const int MaxFramesInFlight = 2;

    private GlfwWindow _window;

    private VulkanInstance? _instance;
    private DebugMessenger? _debugMessenger;

    private VulkanSurface? _surface;

    private PhysicalDevice? _physicalDevice;
    private VulkanDevice? _device;

    private uint _graphicsQueueFamilyIndex;
    private VulkanQueue? _queue;

    private VulkanSwapchain[]? _swapchains;
    private VulkanSwapchain _swapchain => _swapchains![0];

    private ImageView[]? _imageViews;
    private VulkanFence[]? _submitFences;
    private CommandPool[]? _commandPools;
    private CommandBuffer[]? _commandBuffers;
    private VulkanSemaphore[]? _acquireSemaphores;
    private VulkanSemaphore[]? _releaseSemaphores;

    private SemaphorePool? _semaphorePool;
    private RenderPass? _renderPass;

    private PipelineLayout? _pipelineLayout;
    private Pipeline? _pipeline;

    private Framebuffer[]? _frameBuffers;

    VkPipelineStageFlags[]? _waitStages;

    private bool _framebufferResized;
    
    public void Run()
    {
        Prepare();

        while (!Glfw.WindowShouldClose(_window))
        {
            Glfw.PollEvents();

            var result = AcquireNextImage(out var imageIndex);

            if (result == AcquireNextImageResult.Suboptimal || result == AcquireNextImageResult.OutOfDate)
            {
                RecreateSwapChain();
                result = AcquireNextImage(out imageIndex);
            }

            if (result != AcquireNextImageResult.Success)
            {
                _queue!.WaitIdle();
                continue;
            }

            RenderTriangle(imageIndex);

            var presentResult = _queue!.Present(
                _swapchains,
                _releaseSemaphores!.AsSpan().Slice((int) imageIndex, 1),
                stackalloc[] { imageIndex }
            );

            if (presentResult == QueuePresentResult.OutOfDate || presentResult == QueuePresentResult.Suboptimal || _framebufferResized)
            {
                _framebufferResized = false;

                RecreateSwapChain();
            }
        }

        _device!.WaitIdle();

        Teardown();

        Glfw.DestroyWindow(_window);

        Glfw.Terminate();
    }

    private void Prepare()
    {
        var api = VulkanApi.Initialize();

        Glfw.SetErrorCallback((errorCode, message) =>
        {
            throw new Exception($"GLFW error {errorCode}: {message}");
        });

        Glfw.WindowHint(Hint.ClientApi, 0);

        _window = Glfw.CreateWindow(800, 600, "Hello Triangle");

        _framebufferResized = false;

        Glfw.SetWindowSizeCallback(_window, (window, width, height) =>
        {
            _framebufferResized = true;
        });

        var requiredExtensions = Glfw.Vulkan.GetRequiredInstanceExtensions();

        InitializeInstance(api, requiredExtensions);

        Glfw.Vulkan.CreateWindowSurface(_instance!.Handle, _window, null, out nint surfaceHandle);

        _surface = _instance.LoadSurface(surfaceHandle);

        var requiredDeviceExtensions = new[] { "VK_KHR_swapchain" };

        InitializeDevice(requiredDeviceExtensions);
        InitializeSwapchain();
        InitializeImageViews();
        InitializeRenderPass();
        InitializePipeline();
        InitializeFramebuffers();

        _semaphorePool = new(_device!);
    }

    private void Teardown()
    {
        for (var i = 0; i < _imageViews!.Length; i++)
        {
            _acquireSemaphores![i].Dispose();
            _releaseSemaphores![i].Dispose();
            _submitFences![i].Dispose();
            _commandPools![i].Dispose();
        }

        _semaphorePool!.Dispose();

        for (var i = 0; i < _frameBuffers!.Length; i++)
        {
            _frameBuffers[i].Dispose();
        }

        for (var i = 0; i < _imageViews!.Length; i++)
        {
            _imageViews[i].Dispose();
        }

        _pipeline!.Dispose();

        _pipelineLayout!.Dispose();
        _renderPass!.Dispose();
        _swapchain.Dispose();
        _surface!.Dispose();
        _device!.Dispose();

#if DEBUG
        _debugMessenger!.Dispose();
#endif

        _instance!.Dispose();
    }

    private void InitializeInstance(VulkanApi api, string[] requiredExtensions)
    {
        api.EnumerateInstanceExtensionProperties(null, out var availableExtensions);

        List<string> activeExtension = new();

        foreach (var extension in requiredExtensions)
        {
            activeExtension.Add(extension);
        }

#if DEBUG
        activeExtension.Add("VK_EXT_debug_utils");
#endif

        // TODO: Portability
        // TODO: platform specific

        var activeExtensionNames = activeExtension.ToArray();

        if (!ValidateExtensions(activeExtensionNames, availableExtensions))
        {
            throw new InvalidOperationException("Required instance extensions are missing.");
        }

        api.EnumerateInstanceLayerProperties(out var availableLayers);

        List<string> activeLayers = new();

#if DEBUG
        activeLayers.Add("VK_LAYER_KHRONOS_validation");
#endif

        var activeLayerNames = activeLayers.ToArray();

        if (!ValidateLayers(activeLayerNames, availableLayers))
        {
            throw new InvalidOperationException("Required validation layers are missing.");
        }

        _instance = api.CreateVulkanInstance(new InstanceDefinition
        {
            AppName = "Hello Triangle",
            EngineName = "MyEngine",
            ApiVersion = new VulkanVersion(1, 0, 0),
            EnabledExtensions = activeExtensionNames,
            EnabledLayers = activeLayerNames
        });

#if DEBUG
        var debugUtils = _instance.LoadDebugUtilsExtension();

        _debugMessenger = debugUtils.CreateMessenger();

        _debugMessenger.OnMessage += Console.WriteLine;
#endif
    }

    private void InitializeDevice(string[] requiredDeviceExtensions)
    {
        var physicalDevices = _instance!.GetPhysicalDevices();

        int graphicsQueueFamilyIndex = -1;

        for (var i = 0; i < physicalDevices.Length && (graphicsQueueFamilyIndex < 0); i++)
        {
            _physicalDevice = physicalDevices[i];

            var queueFamilies = _physicalDevice.GetQueueFamilies();

            if (queueFamilies.Length < 1)
            {
                throw new InvalidOperationException("No queue family found.");
            }

            for (var j = 0; j < queueFamilies.Length; j++)
            {
                var supportsPresent = _surface!.SupportsDeviceQueueFamily(_physicalDevice, (uint)j);

                // Find a queue family which supports graphics and presentation.
                if (queueFamilies[j].queueFlags.HasFlag(VkQueueFlags.VK_QUEUE_GRAPHICS_BIT) && supportsPresent)
                {
                    graphicsQueueFamilyIndex = j;
                    break;
                }
            }
        }

        if (graphicsQueueFamilyIndex < 0)
        {
            throw new InvalidOperationException("Graphics Queue Family does not exist.");
        }

        _graphicsQueueFamilyIndex = (uint)graphicsQueueFamilyIndex;

        var availableDeviceExtensions = _physicalDevice!.GetExtensions();



        if (!ValidateExtensions(requiredDeviceExtensions, availableDeviceExtensions))
        {
            throw new NotSupportedException("Device does not support swapchains.");
        }

        var deviceQueues = new[]
        {
            new DeviceQueue
            {
                QueueFamilyIndex = _graphicsQueueFamilyIndex,
                QueuePriorites = new float[] { 1 }
            }
        };

        _device = _physicalDevice.CreateLogicalDevice(requiredDeviceExtensions, deviceQueues);

        _queue = _device.GetQueue(_graphicsQueueFamilyIndex, 0);
    }

    private void InitializeSwapchain()
    {
        var capabilities = _surface!.GetCapabilities(_physicalDevice!);

        var surfaceFormat = ChooseSurfaceFormat();
        var swapExtent = ChooseSwapExtent(ref capabilities);
        var presentMode = ChoosePresentMode();
        var preTransform = ChooseSurfaceTransform(capabilities);
        var composite = ChooseCompositType(capabilities);

        var queueFamilyIndeces = Array.Empty<uint>();

        var oldSwapchain = _swapchains?[0]?.Handle ?? nint.Zero;

        _swapchains ??= new VulkanSwapchain[1];

        _swapchains[0] = _device!.CreateSwapchain(new SwapchainDefinition
        {
            Surface = _surface,
            // Always include 1 more then the minimum, or max value if it is not zero (infinite).
            MinImageCount = Math.Min(capabilities.minImageCount + 1, Math.Max(capabilities.maxImageCount, uint.MaxValue)),
            SurfaceFormat = surfaceFormat,
            ImageExtent = swapExtent,
            ImageArrayLayers = 1, // 1 unless doing stereoscopic 3D
            ImageUsage = VkImageUsageFlags.VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
            SharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
            QueueFamilyIndeces = queueFamilyIndeces,
            PreTransform = preTransform,
            CompositeAlpha = composite,
            PresentMode = presentMode,
            Clipped = true,
            OldSwapchain = oldSwapchain
        });
    }

    private void InitializeImageViews()
    {
        var images = _swapchain.GetImages();

        _imageViews = new ImageView[images.Length];
        _submitFences = new VulkanFence[images.Length];
        _commandPools = new CommandPool[images.Length];
        _commandBuffers = new CommandBuffer[images.Length];
        _acquireSemaphores = new VulkanSemaphore[images.Length];
        _releaseSemaphores = new VulkanSemaphore[images.Length];

        for (var i = 0; i < _imageViews.Length; i++)
        {
            _imageViews[i] = _device!.CreateImageView(new ImageViewCreateInfo
            {
                Image = images[i],
                Format = _swapchain.SurfaceFormat.format,
                ViewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                Components = new VkComponentMapping
                {
                    r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_R,
                    g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_G,
                    b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_B,
                    a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_A
                },
                SubresourceRange = new VkImageSubresourceRange
                {
                    aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT,
                    baseMipLevel = 0,
                    levelCount = 1,
                    baseArrayLayer = 0,
                    layerCount = 1
                }
            });

            _submitFences[i] = _device!.CreateFence(VkFenceCreateFlags.VK_FENCE_CREATE_SIGNALED_BIT);

            _commandPools[i] = _device!.CreateCommandPool(VkCommandPoolCreateFlags.VK_COMMAND_POOL_CREATE_TRANSIENT_BIT, _graphicsQueueFamilyIndex);

            _commandBuffers[i] = _commandPools[i].AllocateCommandBuffer(VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY);
        }
        
    }

    private void InitializeRenderPass()
    {
        _renderPass = _device!.CreateRenderPass(
            new[]
            {
                new SubpassDescription
                {
                    BindPoint = VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS,
                    ColorAttachments = new []
                    {
                        new VkAttachmentReference
                        {
                            attachment = 0,
                            layout = VkImageLayout.VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL
                        }
                    }
                }
            },
            new[]
            {
                new VkAttachmentDescription
                {
                    format = _swapchain.SurfaceFormat.format,
                    samples  = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT,
                    loadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_CLEAR,
                    storeOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_STORE,
                    stencilLoadOp  = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_DONT_CARE,
                    stencilStoreOp  = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_DONT_CARE,
                    initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
                    finalLayout = VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR,
                }
            },
            new[]
            {
                new VkSubpassDependency
                {
                    srcSubpass = VulkanApiConstants.VK_SUBPASS_EXTERNAL,
                    dstSubpass = 0,
                    srcStageMask = VkPipelineStageFlags.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
                    srcAccessMask = 0,
                    dstStageMask = VkPipelineStageFlags.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
                    dstAccessMask = VkAccessFlags.VK_ACCESS_COLOR_ATTACHMENT_READ_BIT  | VkAccessFlags.VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT
                }
            }
        );
    }

    private void InitializePipeline()
    {
        byte[] vertBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "vert.spv"));
        byte[] fragBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "frag.spv"));

        var vertShader = _device!.CreateShaderModule(vertBytes);
        var fragShader = _device.CreateShaderModule(fragBytes);

        _pipelineLayout = _device.CreatePipelineLayout();

        var graphicsPipelines = _device.CreateGraphicsPipelines(new[]
        {
            new GraphicsPipelineDefinition
            {
                RenderPass = _renderPass!,
                PipelineLayout = _pipelineLayout,
                DynamicStates = new[]
                {
                    VkDynamicState.VK_DYNAMIC_STATE_VIEWPORT,
                    VkDynamicState.VK_DYNAMIC_STATE_SCISSOR,
                },
                VertexInputState = new(), // no vertex data to load for now
                InputAssemblyState = new()
                {
                    Topology = VkPrimitiveTopology.VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST,
                    PrimitiveRestartEnable = false
                },
                Stages = new ShaderStage[]
                {
                    new ShaderStage
                    {
                        Name = "main",
                        Stage = VkShaderStageFlags.VK_SHADER_STAGE_VERTEX_BIT,
                        Module = vertShader
                    },
                    new ShaderStage
                    {
                        Name = "main",
                        Stage = VkShaderStageFlags.VK_SHADER_STAGE_FRAGMENT_BIT,
                        Module = fragShader
                    }
                },
                ViewportState = new()
                {
                    Viewports = new []
                    {
                        new VkViewport
                        {
                            x = 0,
                            y = 0,
                            width = _swapchain.ImageExtent.width,
                            height = _swapchain.ImageExtent.height,
                            minDepth = 0,
                            maxDepth = 1.0f,
                        }
                    },
                    Scissors = new[]
                    {
                        new VkRect2D
                        {
                            offset = new () { x = 0, y = 0 },
                            extent = _swapchain.ImageExtent
                        }
                    }
                },
                RasterizationState = new()
                {
                    LineWidth = 1,
                    CullMode = VkCullModeFlags.VK_CULL_MODE_BACK_BIT,
                    FrontFace = VkFrontFace.VK_FRONT_FACE_CLOCKWISE,
                },
                MultisampleState = new()
                {
                    RasterizationSamples = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT,
                    MinSampleShading = 1,
                },
                ColorBlendState = new()
                {
                    Attachments = new[]
                    {
                        new ColorBlendAttachmentState()
                        {
                            ColorWriteMask = VkColorComponentFlags.VK_COLOR_COMPONENT_R_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_G_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_B_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_A_BIT,
                        }
                    }
                }
            }
        });

        _pipeline = graphicsPipelines[0];

        vertShader.Dispose();
        fragShader.Dispose();
    }

    private void RecreateSwapChain()
    {
        Glfw.GetFrameBufferSize(_window, out var width, out var height);
        while (width == 0 || height == 0)
        {
            Glfw.GetFrameBufferSize(_window, out width, out height);
            Glfw.WaitEvents();
        }

        _device!.WaitIdle();

        for (var i = 0; i < _frameBuffers!.Length; i++)
        {
            _frameBuffers[i].Dispose();
        }

        for (var i = 0; i < _imageViews!.Length; i++)
        {
            _imageViews[i].Dispose();
            _submitFences![i].Dispose();
            _acquireSemaphores![i].Dispose();
            _releaseSemaphores![i].Dispose();
            _commandPools![i].Dispose();
        }

        _swapchain.Dispose();

        InitializeSwapchain();
        InitializeImageViews();
        InitializeFramebuffers();
    }

    private void InitializeFramebuffers()
    {
        _frameBuffers = new Framebuffer[_imageViews!.Length];

        for (var i = 0; i < _frameBuffers.Length; i++)
        {
            _frameBuffers[i] = _device!.CreateFramebuffer(
                _renderPass!,
                _imageViews.AsSpan().Slice(i, 1),
                _swapchain.ImageExtent.width,
                _swapchain.ImageExtent.height,
                1
            );
        }
    }

    private AcquireNextImageResult AcquireNextImage(out uint imageIndex)
    {
        var acquireSemaphore = _semaphorePool!.GetSemaphore();

        var result = _swapchain.AquireNextImage(out imageIndex, acquireSemaphore);
        if (result != AcquireNextImageResult.Success)
        {
            _semaphorePool!.Return(acquireSemaphore);
            return result;
        }

        _device!.WaitForFence(_submitFences![imageIndex], true);
        _device.ResetFence(_submitFences![imageIndex]);

        _commandPools![imageIndex].Reset();

        var oldSemaphore = _acquireSemaphores![imageIndex];

        if (oldSemaphore is not null)
        {
            _semaphorePool!.Return(oldSemaphore);
        }

        _acquireSemaphores[imageIndex] = acquireSemaphore;

        return result;
    }

    private void RenderTriangle(uint imageIndex)
    {
        _commandBuffers![imageIndex].Begin(VkCommandBufferUsageFlags.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT);

        _commandBuffers[imageIndex].BeginRenderPass(
            _frameBuffers![imageIndex],
            _renderPass!,
            stackalloc[]
            {
            ClearValue.ClearColor(0.01f, 0.01f, 0.033f, 1.0f)
        },
            new VkRect2D
            {
                offset = new() { x = 0, y = 0 },
                extent = _swapchain.ImageExtent
            },
            VkSubpassContents.VK_SUBPASS_CONTENTS_INLINE
        );

        _commandBuffers[imageIndex].BindPipeline(VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS, _pipeline!);

        _commandBuffers[imageIndex].SetViewport(0, stackalloc[]
        {
            new VkViewport
            {
                x = 0,
                y = 0,
                width = _swapchain.ImageExtent.width,
                height = _swapchain.ImageExtent.height,
                minDepth = 0,
                maxDepth = 1.0f,
            }
        });

        _commandBuffers[imageIndex].SetScissor(0, stackalloc[]
        {
            new VkRect2D
            {
                offset = new() { x = 0, y = 0 },
                extent = _swapchain.ImageExtent
            }
        });

        _commandBuffers[imageIndex].Draw(3, 1, 0, 0);

        _commandBuffers[imageIndex].EndRenderPass();

        _commandBuffers[imageIndex].End();

        _releaseSemaphores![imageIndex] ??= _device!.CreateSemaphore();

        _waitStages ??= new[] { VkPipelineStageFlags.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT };

        _queue!.Submit(
            new CommandSubmission
            {
                CommandBuffers = new(_commandBuffers, (int)imageIndex, 1),
                WaitSemaphores = new(_acquireSemaphores!, (int)imageIndex, 1),
                SignalSemaphores = new(_releaseSemaphores, (int)imageIndex, 1),
                WaitStages = _waitStages
            },
            _submitFences![imageIndex]
        );
    }

    private VkPresentModeKHR ChoosePresentMode()
    {
        var presentModes = _surface!.GetPresentModes(_physicalDevice!);

        for (var i = 0; i < presentModes.Length; i++)
        {
            if (presentModes[i] == VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR)
            {
                return presentModes[i];
            }
        }

        return VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR;
    }

    private VkSurfaceFormatKHR ChooseSurfaceFormat()
    {
        var surfaceFormats = _surface!.GetSurfaceFormats(_physicalDevice!);

        for (var i = 0; i < surfaceFormats.Length; i++)
        {
            if (surfaceFormats[i].format == VkFormat.VK_FORMAT_B8G8R8A8_SRGB &&
                surfaceFormats[i].colorSpace == VkColorSpaceKHR.VK_COLOR_SPACE_SRGB_NONLINEAR_KHR)
            {
                return surfaceFormats[i];
            }
        }

        return surfaceFormats[0];
    }

    private VkExtent2D ChooseSwapExtent(ref VkSurfaceCapabilitiesKHR capabilities)
    {
        if (capabilities.currentExtent.width != uint.MaxValue)
        {
            return capabilities.currentExtent;
        }

        Glfw.GetFrameBufferSize(_window, out var width, out var height);

        return new()
        {
            width = (uint)Math.Clamp(width, capabilities.minImageExtent.width, capabilities.maxImageExtent.width),
            height = (uint)Math.Clamp(height, capabilities.minImageExtent.height, capabilities.maxImageExtent.height)
        };
    }

    private static VkSurfaceTransformFlagsKHR ChooseSurfaceTransform(VkSurfaceCapabilitiesKHR capabilities)
    {
        if (capabilities.supportedTransforms.HasFlag(VkSurfaceTransformFlagsKHR.VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR))
        {
            return VkSurfaceTransformFlagsKHR.VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR;
        }
        else
        {
            return capabilities.currentTransform;
        }
    }

    private static VkCompositeAlphaFlagsKHR ChooseCompositType(VkSurfaceCapabilitiesKHR capabilities)
    {
        if (capabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR))
        {
            return VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR;
        }
        else if (capabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR))
        {
            return VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR;
        }
        else if (capabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR))
        {
            return VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR;
        }
        else if (capabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR))
        {
            return VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR;
        }

        return VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR;
    }


    private static bool ValidateExtensions(Span<string> required, Span<ExtensionProperties> available)
    {
        foreach(var extension in required)
        {
            bool found = false;

            foreach(var availableExtension in available)
            {
                if (availableExtension.ExtensionName == extension)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }

        return true;
    }

    private static bool ValidateLayers(Span<string> required, Span<LayerProperties> available)
    {
        foreach (var layer in required)
        {
            bool found = false;

            foreach (var availableLayer in available)
            {
                if (availableLayer.LayerName == layer)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }

        return true;
    }
}
