using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferInfo
{
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkDeviceSize Range;
}