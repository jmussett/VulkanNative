using VulkanNative.Examples.Common.Glfw;
using VulkanNative.Examples.Common;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.HelloTriangle;

internal class HelloTriangle
{
    private const int MaxFramesInFlight = 2;

    private GlfwWindow _window;

    private Framebuffer[] _frameBuffers;
    private ImageView[] _imageViews;
    private VulkanSwapchain[] _swapchains;

    private VulkanInstance _instance;
    private DebugMessenger _debugMessenger;

    public void Run()
    {
        var api = VulkanApi.Initialize();

        Glfw.SetErrorCallback((errorCode, message) =>
        {
            throw new Exception($"GLFW error {errorCode}: {message}");
        });

        Glfw.WindowHint(Hint.ClientApi, 0);

        _window = Glfw.CreateWindow(800, 600, "Hello Triangle");

        bool frameBufferResized = false;

        Glfw.SetWindowSizeCallback(_window, (window, width, height) =>
        {
            frameBufferResized = true;
        });

        var requiredExtensions = Glfw.Vulkan.GetRequiredInstanceExtensions();

        InitializeInstance(api, requiredExtensions);

        Glfw.Vulkan.CreateWindowSurface(_instance.Handle, _window, null, out nint surfaceHandle);

        var surface = _instance.LoadSurface(surfaceHandle);

        // Find physical device

        var physicalDevices = _instance.GetPhysicalDevices();

        // TODO: suitability checks
        // TODO: surface checks
        var physicalDevice = physicalDevices[0];


        // Get graphics queues

        var queueFamilies = physicalDevice.GetQueueFamilies();

        uint? graphicsQueueFamilyIndex = null;
        uint? presentationQueueFamilyIndex = null;

        for (uint i = 0; i < queueFamilies.Length; i++)
        {
            if (queueFamilies[i].queueFlags.HasFlag(VkQueueFlags.VK_QUEUE_GRAPHICS_BIT))
            {
                graphicsQueueFamilyIndex = i;
            }

            if (surface.SupportsDeviceQueueFamily(physicalDevice, i))
            {
                presentationQueueFamilyIndex = i;
            }
        }

        if (!graphicsQueueFamilyIndex.HasValue)
        {
            throw new InvalidOperationException("Graphics Queue Family does not exist.");
        }

        if (!presentationQueueFamilyIndex.HasValue)
        {
            throw new InvalidOperationException("Presentation Queue Family does not exist.");
        }


        // TODO: only include 1 if both are the same
        var deviceQueues = new[]
        {
            new DeviceQueue
            {
                QueueFamilyIndex = graphicsQueueFamilyIndex.Value,
                QueuePriorites = new float[] { 1 }
            },
            new DeviceQueue
            {
                QueueFamilyIndex = presentationQueueFamilyIndex.Value,
                QueuePriorites = new float[] { 1 }
            }
        };

        // Get Device Extensions

        var availableDeviceExtensions = physicalDevice.GetExtensions();

        if (!availableDeviceExtensions.Any(x => x.ExtensionName == "VK_KHR_swapchain"))
        {
            throw new NotSupportedException("Device does not support swapchains.");
        }


        using UnmanagedUtf8StringArray deviceExtensions = new()
        {
            "VK_KHR_swapchain"
        };

        var device = physicalDevice.CreateLogicalDevice(deviceExtensions, deviceQueues);

        var graphicsQueue = device.GetQueue(graphicsQueueFamilyIndex.Value, 0);
        var presentQueue = device.GetQueue(presentationQueueFamilyIndex.Value, 0);

        CreateSwapchain(device, physicalDevice, surface, graphicsQueueFamilyIndex.Value, presentationQueueFamilyIndex.Value);

        CreateImageViews(device);

        byte[] vertBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "vert.spv"));
        byte[] fragBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "frag.spv"));

        var vertShader = device.CreateShaderModule(vertBytes);
        var fragShader = device.CreateShaderModule(fragBytes);

        var pipelineLayout = device.CreatePipelineLayout();
        var renderPass = device.CreateRenderPass(
            new[]
            {
                new SubpassDescription
                {
                    BindPoint = VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS,
                    ColorAttachments = new()
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
                    format = _swapchains[0].SurfaceFormat.format,
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
                    dstAccessMask = VkAccessFlags.VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT
                }
            }
        );

        var graphicsPipelines = device.CreateGraphicsPipelines(new[]
        {
            new GraphicsPipelineDefinition
            {
                RenderPass = renderPass,
                PipelineLayout = pipelineLayout,
                DynamicStates = new()
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
                    Viewports  =new()
                    {
                        new VkViewport
                        {
                            x = 0,
                            y = 0,
                            width = _swapchains[0].ImageExtent.width,
                            height = _swapchains[0].ImageExtent.height,
                            minDepth = 0,
                            maxDepth = 1.0f,
                        }
                    },
                    Scissors = new()
                    {
                        new VkRect2D
                        {
                            offset = new () { x = 0, y = 0 },
                            extent = _swapchains[0].ImageExtent
                        }
                    }
                },
                RasterizationState = new()
                {
                    DepthClampEnable = false,
                    RasterizerDiscardEnable = false,
                    PolygonMode = VkPolygonMode.VK_POLYGON_MODE_FILL,
                    LineWidth = 1,
                    CullMode = VkCullModeFlags.VK_CULL_MODE_BACK_BIT,
                    FrontFace = VkFrontFace.VK_FRONT_FACE_CLOCKWISE,
                    DepthBiasEnable = false,
                    DepthBiasConstantFactor = 0,
                    DepthBiasClamp = 0,
                    DepthBiasSlopeFactor = 0
                },
                MultisampleState = new()
                {
                    SampleShadingEnable = false,
                    RasterizationSamples = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT,
                    MinSampleShading = 1,
                    AlphaToCoverageEnable = false,
                    AlphaToOneEnable = false
                },
                ColorBlendState = new()
                {
                    LogicOpEnable = false,
                    LogicOp = VkLogicOp.VK_LOGIC_OP_COPY,
                    Attachments = new()
                    {
                        new ()
                        {
                            ColorWriteMask = VkColorComponentFlags.VK_COLOR_COMPONENT_R_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_G_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_B_BIT | VkColorComponentFlags.VK_COLOR_COMPONENT_A_BIT,
                            BlendEnable = false,
                            SrcColorBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ONE,
                            DstColorBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ZERO,
                            ColorBlendOp = VkBlendOp.VK_BLEND_OP_ADD,
                            SrcAlphaBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ONE,
                            DstAlphaBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ZERO,
                            AlphaBlendOp = VkBlendOp.VK_BLEND_OP_ADD
                        }
                    }
                },
                BasePipeline = null,
                BasePipelineIndex = -1
            }
        });

        vertShader.Dispose();
        fragShader.Dispose();

        CreateFramebuffers(device, renderPass);

        var commandPool = device.CreateCommandPool(VkCommandPoolCreateFlags.VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT, graphicsQueueFamilyIndex.Value);

        Span<CommandBuffer> commandBuffers = commandPool.AllocateCommandBuffers(MaxFramesInFlight, VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY);

        Span<VulkanSemaphore> imageAvailableSemaphores = new VulkanSemaphore[MaxFramesInFlight];
        Span<VulkanSemaphore> renderFinishedSemaphores = new VulkanSemaphore[MaxFramesInFlight];
        Span<VulkanFence> inFlightFences = new VulkanFence[MaxFramesInFlight];

        for (var i = 0; i < MaxFramesInFlight; i++)
        {
            imageAvailableSemaphores[i] = device.CreateSemaphore();
            renderFinishedSemaphores[i] = device.CreateSemaphore();
            inFlightFences[i] = device.CreateFence(VkFenceCreateFlags.VK_FENCE_CREATE_SIGNALED_BIT);
        }

        using VulkanBuffer<VkPipelineStageFlags> waitStages = new()
        {
            VkPipelineStageFlags.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT
        };

        // seperate queue submissions for each frame
        Span<QueueSubmission> queueSubmissions = new[]
        {
            new QueueSubmission
            {
                CommandBuffers = new[] { commandBuffers[0] },
                SignalSemaphores = new[] { renderFinishedSemaphores[0] },
                WaitSemaphores = new[] { imageAvailableSemaphores[0] },
                WaitStages = waitStages
            },
            new QueueSubmission
            {
                CommandBuffers = new[] { commandBuffers[1] },
                SignalSemaphores = new[] { renderFinishedSemaphores[1] },
                WaitSemaphores = new[] { imageAvailableSemaphores[1] },
                WaitStages = waitStages
            }
        };

        int currentFrame = 0;

        while (!Glfw.WindowShouldClose(_window))
        {
            Glfw.PollEvents();

            device.WaitForFences(inFlightFences.Slice(currentFrame, 1), true);

            var result = _swapchains[0].AquireNextImage(out var imageIndex, imageAvailableSemaphores[currentFrame]);

            if (result == AcquireNextImageResult.OutOfDate)
            {
                RecreateSwapChain(device, physicalDevice, renderPass, surface, graphicsQueueFamilyIndex.Value, presentationQueueFamilyIndex.Value);
                continue;
            }
            else if (result != AcquireNextImageResult.Success && result != AcquireNextImageResult.Suboptimal)
            {
                throw new Exception("Failed to acquire swap chain image!");
            }

            device.ResetFences(inFlightFences.Slice(currentFrame, 1));

            commandBuffers[currentFrame].Reset();

            commandBuffers[currentFrame].Begin();

            using VulkanBuffer<ClearValue> clearColors = new()
            {
                ClearValue.ClearColor(0, 0, 0, 0)
            };

            commandBuffers[currentFrame].BeginRenderPass(
                _frameBuffers[imageIndex],
                renderPass,
                clearColors,
                new VkRect2D
                {
                    offset = new() { x = 0, y = 0 },
                    extent = _swapchains[0].ImageExtent
                },
                VkSubpassContents.VK_SUBPASS_CONTENTS_INLINE
            );

            commandBuffers[currentFrame].BindPipeline(VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS, graphicsPipelines[0]);

            using VulkanBuffer<VkViewport> viewports = new()
            {
                new VkViewport
                {
                    x = 0,
                    y = 0,
                    width = _swapchains[0].ImageExtent.width,
                    height = _swapchains[0].ImageExtent.height,
                    minDepth = 0,
                    maxDepth = 1.0f,
                }
            };

            commandBuffers[currentFrame].SetViewport(0, viewports);

            using VulkanBuffer<VkRect2D> scissors = new()
            {
                new VkRect2D
                {
                    offset = new() { x = 0, y = 0 },
                    extent = _swapchains[0].ImageExtent
                }
            };

            commandBuffers[currentFrame].SetScissor(0, scissors);

            commandBuffers[currentFrame].Draw(3, 1, 0, 0);

            commandBuffers[currentFrame].EndRenderPass();

            commandBuffers[currentFrame].End();

            graphicsQueue.Submit(queueSubmissions.Slice(currentFrame, 1), inFlightFences[currentFrame]);

            using VulkanBuffer<uint> imageIndeces = new() { imageIndex };

            var presentResult = presentQueue.Present(_swapchains, renderFinishedSemaphores.Slice(currentFrame, 1), imageIndeces);

            if (presentResult == QueuePresentResult.OutOfDate || presentResult == QueuePresentResult.Suboptimal || frameBufferResized)
            {
                frameBufferResized = false;

                RecreateSwapChain(device, physicalDevice, renderPass, surface, graphicsQueueFamilyIndex.Value, presentationQueueFamilyIndex.Value);
            }

            currentFrame = (currentFrame + 1) % MaxFramesInFlight;
        }

        device.WaitIdle();

        for (var i = 0; i < MaxFramesInFlight; i++)
        {
            imageAvailableSemaphores[i].Dispose();
            renderFinishedSemaphores[i].Dispose();
            inFlightFences[i].Dispose();
        }

        commandPool.Dispose();

        for (var i = 0; i < _frameBuffers.Length; i++)
        {
            _frameBuffers[i].Dispose();
        }

        // TODO: move down?
        for (var i = 0; i < _imageViews.Length; i++)
        {
            _imageViews[i].Dispose();
        }

        for (var i = 0; i < graphicsPipelines.Length; i++)
        {
            graphicsPipelines[i].Dispose();
        }

        pipelineLayout.Dispose();
        renderPass.Dispose();
        _swapchains[0].Dispose();
        surface.Dispose();
        device.Dispose();

#if DEBUG
        _debugMessenger.Dispose();
#endif

        _instance.Dispose();

        Glfw.DestroyWindow(_window);

        Glfw.Terminate();
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

        _debugMessenger.OnMessage += message =>
        {
            Console.WriteLine(message);
        };
#endif
    }

    private void RecreateSwapChain(VulkanDevice device, PhysicalDevice physicalDevice, RenderPass renderPass, VulkanSurface surface, uint graphicsQueueFamilyIndex, uint presentationQueueFamilyIndex)
    {
        Glfw.GetFrameBufferSize(_window, out var width, out var height);
        while (width == 0 || height == 0)
        {
            Glfw.GetFrameBufferSize(_window, out width, out height);
            Glfw.WaitEvents();
        }

        device.WaitIdle();

        for (var i = 0; i < _frameBuffers.Length; i++)
        {
            _frameBuffers[i].Dispose();
        }

        // TODO: move down?
        for (var i = 0; i < _imageViews.Length; i++)
        {
            _imageViews[i].Dispose();
        }

        _swapchains[0].Dispose();

        CreateSwapchain(device, physicalDevice, surface, graphicsQueueFamilyIndex, presentationQueueFamilyIndex);
        CreateImageViews(device);
        CreateFramebuffers(device, renderPass);
    }

    private void CreateSwapchain(VulkanDevice device, PhysicalDevice physicalDevice, VulkanSurface surface, uint graphicsQueueFamilyIndex, uint presentationQueueFamilyIndex)
    {
        var capabilities = surface.GetCapabilities(physicalDevice);

        var presentMode = ChoosePresentMode(surface, physicalDevice);
        var surfaceFormat = ChooseSurfaceFormat(surface, physicalDevice);
        var swapExtent = ChooseSwapExtent(ref capabilities);

        uint[] queueFamilyIndeces;
        VkSharingMode sharingMode;

        if (presentationQueueFamilyIndex == graphicsQueueFamilyIndex)
        {
            queueFamilyIndeces = Array.Empty<uint>();
            sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
        }
        else
        {
            queueFamilyIndeces = new uint[] { graphicsQueueFamilyIndex, presentationQueueFamilyIndex };
            sharingMode = VkSharingMode.VK_SHARING_MODE_CONCURRENT;
        }

        _swapchains ??= new VulkanSwapchain[1]; 

        _swapchains[0] = device.CreateSwapchain(new SwapchainDefinition
        {
            Surface = surface,
            // Always include 1 more then the minimum, or max value if it is not zero (infinite).
            MinImageCount = Math.Min(capabilities.minImageCount + 1, Math.Max(capabilities.maxImageCount, uint.MaxValue)),
            SurfaceFormat = surfaceFormat,
            ImageExtent = swapExtent, // TODO: use glfwGetFramebufferSize
            ImageArrayLayers = 1, // 1 unless doing stereoscopic 3D
            ImageUsage = VkImageUsageFlags.VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
            SharingMode = sharingMode,
            QueueFamilyIndeces = queueFamilyIndeces,
            PreTransform = capabilities.currentTransform,
            CompositeAlpha = VkCompositeAlphaFlagsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR,
            PresentMode = presentMode,
            Clipped = true,
            OldSwapchain = nint.Zero // TODO: needed for swapchain resize
        });
    }

    private void CreateImageViews(VulkanDevice device)
    {
        // TODO: maybe use vector instead of array?
        var images = _swapchains[0].GetImages();

        _imageViews = new ImageView[images.Length];

        for (var i = 0; i < _imageViews.Length; i++)
        {
            _imageViews[i] = device.CreateImageView(new ImageViewCreateInfo
            {
                Image = images[i],
                Format = _swapchains[0].SurfaceFormat.format,
                ViewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                Components = new VkComponentMapping
                {
                    r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                    g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                    b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                    a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY
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
        }
    }

    private void CreateFramebuffers(VulkanDevice device, RenderPass renderPass)
    {
        _frameBuffers = new Framebuffer[_imageViews.Length];

        for (var i = 0; i < _frameBuffers.Length; i++)
        {
            _frameBuffers[i] = device.CreateFramebuffer(
                renderPass,
                _imageViews.AsSpan().Slice(i, 1),
                _swapchains[0].ImageExtent.width,
                _swapchains[0].ImageExtent.height,
                1
            );
        }
    }

    private static VkPresentModeKHR ChoosePresentMode(VulkanSurface surface, PhysicalDevice physicalDevice)
    {
        var presentModes = surface.GetPresentModes(physicalDevice);

        for (var i = 0; i < presentModes.Length; i++)
        {
            if (presentModes[i] == VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR)
            {
                return presentModes[i];
            }
        }

        return VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR;
    }

    private static VkSurfaceFormatKHR ChooseSurfaceFormat(VulkanSurface surface, PhysicalDevice physicalDevice)
    {
        var surfaceFormats = surface.GetSurfaceFormats(physicalDevice);

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
