using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCompressionFlagsEXT imageCompressionFlags;
    public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;

    public VkImageCompressionPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT;
    }
}