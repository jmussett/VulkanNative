using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryRequirements
{
    public VkDeviceSize Size;
    public VkDeviceSize Alignment;
    public uint MemoryTypeBits;
}