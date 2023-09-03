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

// Dispose after creating graphics pipeline
vertShader.Dispose();
fragShader.Dispose();

while (!Glfw.WindowShouldClose(window))
{
    Glfw.PollEvents();
}

for (var i = 0; i < imageViews.Length; i++)
{
    imageViews[i].Dispose();
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