using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateFlags flags;
    public VkDeviceSize size;
    public VkBufferUsageFlags usage;
    public VkSharingMode sharingMode;
    public uint queueFamilyIndexCount;
    public uint* pQueueFamilyIndices;

    public VkBufferCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
    }
}