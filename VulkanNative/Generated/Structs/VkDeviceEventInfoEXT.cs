using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceEventInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceEventTypeEXT DeviceEvent;
}