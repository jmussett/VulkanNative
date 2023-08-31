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
}