using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferUsageFlags2CreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferUsageFlags2KHR usage;

    public VkBufferUsageFlags2CreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR;
    }
}