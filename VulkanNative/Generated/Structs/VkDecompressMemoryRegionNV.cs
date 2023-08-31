using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDecompressMemoryRegionNV
{
    public VkDeviceAddress srcAddress;
    public VkDeviceAddress dstAddress;
    public VkDeviceSize compressedSize;
    public VkDeviceSize decompressedSize;
    public VkMemoryDecompressionMethodFlagsNV decompressionMethod;
}