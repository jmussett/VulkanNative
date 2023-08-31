using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalSemaphoreHandleTypeFlags handleType;

    public VkPhysicalDeviceExternalSemaphoreInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO;
    }
}