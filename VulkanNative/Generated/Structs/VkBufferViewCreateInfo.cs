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

    public VkBufferViewCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO;
    }
}