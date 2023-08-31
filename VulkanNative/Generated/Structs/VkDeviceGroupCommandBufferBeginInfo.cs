using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceMask;

    public VkDeviceGroupCommandBufferBeginInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO;
    }
}