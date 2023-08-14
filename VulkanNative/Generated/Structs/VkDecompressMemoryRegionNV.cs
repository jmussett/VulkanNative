using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDecompressMemoryRegionNV
{
    public VkDeviceAddress SrcAddress;
    public VkDeviceAddress DstAddress;
    public VkDeviceSize CompressedSize;
    public VkDeviceSize DecompressedSize;
    public VkMemoryDecompressionMethodFlagsNV DecompressionMethod;
}