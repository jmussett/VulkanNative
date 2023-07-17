using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferViewCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferViewCreateFlags flags;
    public VkBuffer buffer;
    public VkFormat format;
    public VkDeviceSize offset;
    public VkDeviceSize range;
}