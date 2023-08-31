using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryRequirements
{
    public VkDeviceSize size;
    public VkDeviceSize alignment;
    public uint memoryTypeBits;
}