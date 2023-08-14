using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionControlEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCompressionFlagsEXT Flags;
    public uint CompressionControlPlaneCount;
    public VkImageCompressionFixedRateFlagsEXT* PFixedRateFlags;
}