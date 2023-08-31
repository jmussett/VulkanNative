using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilities2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint minImageCount;
    public uint maxImageCount;
    public VkExtent2D currentExtent;
    public VkExtent2D minImageExtent;
    public VkExtent2D maxImageExtent;
    public uint maxImageArrayLayers;
    public VkSurfaceTransformFlagsKHR supportedTransforms;
    public VkSurfaceTransformFlagsKHR currentTransform;
    public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
    public VkImageUsageFlags supportedUsageFlags;
    public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
}