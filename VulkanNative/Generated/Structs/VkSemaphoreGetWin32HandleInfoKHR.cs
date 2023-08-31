using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkExternalSemaphoreHandleTypeFlags handleType;

    public VkSemaphoreGetWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR;
    }
}