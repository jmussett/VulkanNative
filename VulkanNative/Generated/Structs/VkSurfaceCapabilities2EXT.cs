using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilities2EXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MinImageCount;
    public uint MaxImageCount;
    public VkExtent2D CurrentExtent;
    public VkExtent2D MinImageExtent;
    public VkExtent2D MaxImageExtent;
    public uint MaxImageArrayLayers;
    public VkSurfaceTransformFlagsKHR SupportedTransforms;
    public VkSurfaceTransformFlagsKHR CurrentTransform;
    public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;
    public VkImageUsageFlags SupportedUsageFlags;
    public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters;
}