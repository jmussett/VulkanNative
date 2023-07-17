using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryRequirements
{
    public VkSparseImageFormatProperties formatProperties;
    public uint imageMipTailFirstLod;
    public VkDeviceSize imageMipTailSize;
    public VkDeviceSize imageMipTailOffset;
    public VkDeviceSize imageMipTailStride;
}