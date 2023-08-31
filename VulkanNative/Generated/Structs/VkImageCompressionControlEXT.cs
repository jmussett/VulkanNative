using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionControlEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCompressionFlagsEXT flags;
    public uint compressionControlPlaneCount;
    public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;

    public VkImageCompressionControlEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT;
    }
}