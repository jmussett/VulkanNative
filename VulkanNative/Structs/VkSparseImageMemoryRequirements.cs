using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryRequirements
{
    public VkSparseImageFormatProperties FormatProperties;
    public uint ImageMipTailFirstLod;
    public VkDeviceSize ImageMipTailSize;
    public VkDeviceSize ImageMipTailOffset;
    public VkDeviceSize ImageMipTailStride;
}