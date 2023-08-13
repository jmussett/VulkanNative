using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferViewCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferViewCreateFlags Flags;
    public VkBuffer Buffer;
    public VkFormat Format;
    public VkDeviceSize Offset;
    public VkDeviceSize Range;
}