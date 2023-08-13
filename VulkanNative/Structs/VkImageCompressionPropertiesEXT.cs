using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCompressionFlagsEXT ImageCompressionFlags;
    public VkImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;
}