using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSwapchainCreateFlagsKHR Flags;
    public VkSurfaceKHR Surface;
    public uint MinImageCount;
    public VkFormat ImageFormat;
    public VkColorSpaceKHR ImageColorSpace;
    public VkExtent2D ImageExtent;
    public uint ImageArrayLayers;
    public VkImageUsageFlags ImageUsage;
    public VkSharingMode ImageSharingMode;
    public uint QueueFamilyIndexCount;
    public uint* PQueueFamilyIndices;
    public VkSurfaceTransformFlagsKHR PreTransform;
    public VkCompositeAlphaFlagsKHR CompositeAlpha;
    public VkPresentModeKHR PresentMode;
    public VkBool32 Clipped;
    public VkSwapchainKHR OldSwapchain;
}