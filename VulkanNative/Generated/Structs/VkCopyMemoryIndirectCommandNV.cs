using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryIndirectCommandNV
{
    public VkDeviceAddress SrcAddress;
    public VkDeviceAddress DstAddress;
    public VkDeviceSize Size;
}