using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkExternalSemaphoreHandleTypeFlags handleType;
}