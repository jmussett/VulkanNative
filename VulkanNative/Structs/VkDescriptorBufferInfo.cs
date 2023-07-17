using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferInfo
{
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkDeviceSize range;
}