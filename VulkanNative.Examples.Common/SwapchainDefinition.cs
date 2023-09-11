namespace VulkanNative.Examples.Common;

public struct SwapchainDefinition
{
    public VulkanSurface Surface;
    public uint MinImageCount;
    public VkSurfaceFormatKHR SurfaceFormat;
    public VkExtent2D ImageExtent;
    public uint ImageArrayLayers;
    public VkImageUsageFlags ImageUsage;
    public VkSharingMode SharingMode;
    public uint[] QueueFamilyIndeces;
    public VkSurfaceTransformFlagsKHR PreTransform;
    public VkCompositeAlphaFlagsKHR CompositeAlpha;
    public VkPresentModeKHR PresentMode;
    public bool Clipped;
    public nint OldSwapchain;
}