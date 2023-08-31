using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkExternalSemaphoreHandleTypeFlags handleType;

    public VkSemaphoreGetFdInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR;
    }
}