using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainCreateFlagsKHR flags;
    public VkSurfaceKHR surface;
    public uint minImageCount;
    public VkFormat imageFormat;
    public VkColorSpaceKHR imageColorSpace;
    public VkExtent2D imageExtent;
    public uint imageArrayLayers;
    public VkImageUsageFlags imageUsage;
    public VkSharingMode imageSharingMode;
    public uint queueFamilyIndexCount;
    public uint* pQueueFamilyIndices;
    public VkSurfaceTransformFlagsKHR preTransform;
    public VkCompositeAlphaFlagsKHR compositeAlpha;
    public VkPresentModeKHR presentMode;
    public VkBool32 clipped;
    public VkSwapchainKHR oldSwapchain;
}