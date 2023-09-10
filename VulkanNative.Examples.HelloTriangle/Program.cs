using VulkanNative;
using VulkanNative.Examples.Common;
using VulkanNative.Examples.Common.Glfw;
using VulkanNative.Examples.Common.Utility;

var api = VulkanApi.Initialize();

Glfw.SetErrorCallback((errorCode, message) =>
{
    throw new Exception($"GLFW error {errorCode}: {message}");
});

Glfw.WindowHint(Hint.ClientApi, 0);
Glfw.WindowHint(Hint.Resizable, false);

var window = Glfw.CreateWindow(800, 600, "Hello Triangle");

// TODO: Validate
api.EnumerateInstanceExtensionProperties(null, out var extensionProperties);
api.EnumerateInstanceLayerProperties(out var layerProperties);

var glfwExtensions = Glfw.Vulkan.GetRequiredInstanceExtensions();

using UnmanagedUtf8StringArray enabledExtensionNames = new()
{
    "VK_EXT_debug_utils"
};

foreach (var extension in glfwExtensions)
{
    enabledExtensionNames.Add(extension);
}

using UnmanagedUtf8StringArray enabledLayerNames = new()
{
    "VK_LAYER_KHRONOS_validation"
};

var instance = api.CreateVulkanInstance("MyApp", "MyEngine", enabledExtensionNames, enabledLayerNames);

var debugUtils = instance.LoadDebugUtilsExtension();

var messenger = debugUtils.CreateMessenger();

messenger.OnMessage += message =>
{
    Console.WriteLine(message);
};

Glfw.Vulkan.CreateWindowSurface(instance.Handle, window, null, out nint surfaceHandle);

var surface = instance.LoadSurface(surfaceHandle);

// Find physical device

var physicalDevices = instance.GetPhysicalDevices();

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

var capabilities = surface.GetCapabilities(physicalDevice);
var presentModes = surface.GetPresentModes(physicalDevice);
var surfaceFormats = surface.GetSurfaceFormats(physicalDevice);

var presentMode = ChoosePresentMode(presentModes);
var surfaceFormat = ChooseSurfaceFormat(surfaceFormats);

uint[] queueFamilyIndeces;
VkSharingMode sharingMode;

if (presentationQueueFamilyIndex == graphicsQueueFamilyIndex)
{
    queueFamilyIndeces = Array.Empty<uint>();
    sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
}
else
{
    queueFamilyIndeces = new uint[] { (uint)graphicsQueueFamilyIndex, (uint) presentationQueueFamilyIndex };
    sharingMode = VkSharingMode.VK_SHARING_MODE_CONCURRENT;
}

var swapchain = device.CreateSwapchain(new SwapchainCreateInfo
{
    Surface = surface,
    // Always include 1 more then the minimum, or max value if it is not zero (infinite).
    MinImageCount = Math.Min(capabilities.minImageCount + 1, Math.Max(capabilities.maxImageCount, uint.MaxValue)),
    SurfaceFormat = surfaceFormat,
    ImageExtent = capabilities.currentExtent, // TODO: use glfwGetFramebufferSize
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

// TODO: maybe use vector instead of array?
var images = swapchain.GetImages();

var imageViews = new ImageView[images.Length];

for (var i = 0; i < imageViews.Length; i++)
{
    imageViews[i] = device.CreateImageView(new ImageViewCreateInfo
    {
        Image = images[i],
        Format = surfaceFormat.format,
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

byte[] vertBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "vert.spv"));
byte[] fragBytes = File.ReadAllBytes(Path.Combine(AppContext.BaseDirectory, "Shaders", "frag.spv"));

var vertShader = device.CreateShaderModule(vertBytes);
var fragShader = device.CreateShaderModule(fragBytes);

var pipelineLayout = device.CreatePipelineLayout();
var renderPass = device.CreateRenderPass(new[]
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
        format = surfaceFormat.format,
        samples  = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT,
        loadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_CLEAR,
        storeOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_STORE,
        stencilLoadOp  = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_DONT_CARE,
        stencilStoreOp  = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_DONT_CARE,
        initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
        finalLayout = VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR,
    }
});

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
                    width = capabilities.currentExtent.width, 
                    height = capabilities.currentExtent.height,
                    minDepth = 0,
                    maxDepth = 1.0f,
                }
            },
            Scissors = new()
            {
                new VkRect2D
                {
                    offset = new () { x = 0, y = 0 },
                    extent = capabilities.currentExtent
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

var framebuffers = new Framebuffer[imageViews.Length];

for (var i = 0; i < framebuffers.Length; i++)
{
    framebuffers[i] = device.CreateFramebuffer(
        renderPass, 
        imageViews.AsSpan().Slice(i, 1), 
        capabilities.currentExtent.width, 
        capabilities.currentExtent.height, 
        1
    );
}

var commandPool = device.CreateCommandPool(VkCommandPoolCreateFlags.VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT, graphicsQueueFamilyIndex.Value);

var commandBuffers = commandPool.AllocateCommandBuffers(1, VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY);

commandBuffers[0].Begin();

while (!Glfw.WindowShouldClose(window))
{
    Glfw.PollEvents();
}

commandPool.Dispose();

for (var i = 0; i < framebuffers.Length; i++)
{
    framebuffers[i].Dispose();
}

// TODO: move down?
for (var i = 0; i < imageViews.Length; i++)
{
    imageViews[i].Dispose();
}

for(var i = 0; i < graphicsPipelines.Length; i++)
{
    graphicsPipelines[i].Dispose();
}

pipelineLayout.Dispose();
renderPass.Dispose();
swapchain.Dispose();
surface.Dispose();
device.Dispose();
messenger.Dispose();
instance.Dispose();

Glfw.DestroyWindow(window);

Glfw.Terminate();

static VkPresentModeKHR ChoosePresentMode(VkPresentModeKHR[] presentModes)
{
    for (var i = 0; i < presentModes.Length; i++)
    {
        if (presentModes[i] == VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR)
        {
            return presentModes[i];
        }
    }

    return VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR;
}

static VkSurfaceFormatKHR ChooseSurfaceFormat(VkSurfaceFormatKHR[] surfaceFormats)
{
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