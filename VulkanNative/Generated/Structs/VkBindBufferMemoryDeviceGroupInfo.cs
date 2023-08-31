using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceIndexCount;
    public uint* pDeviceIndices;

    public VkBindBufferMemoryDeviceGroupInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO;
    }
}