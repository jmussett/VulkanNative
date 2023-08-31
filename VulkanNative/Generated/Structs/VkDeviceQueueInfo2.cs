using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceQueueCreateFlags flags;
    public uint queueFamilyIndex;
    public uint queueIndex;

    public VkDeviceQueueInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2;
    }
}