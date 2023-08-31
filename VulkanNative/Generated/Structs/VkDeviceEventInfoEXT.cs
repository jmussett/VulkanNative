using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceEventInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceEventTypeEXT deviceEvent;

    public VkDeviceEventInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT;
    }
}