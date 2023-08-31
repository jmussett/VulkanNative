using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalFenceHandleTypeFlags handleType;

    public VkPhysicalDeviceExternalFenceInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO;
    }
}