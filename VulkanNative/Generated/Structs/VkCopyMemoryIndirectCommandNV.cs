using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryIndirectCommandNV
{
    public VkDeviceAddress srcAddress;
    public VkDeviceAddress dstAddress;
    public VkDeviceSize size;
}