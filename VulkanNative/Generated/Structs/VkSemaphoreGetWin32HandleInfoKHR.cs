using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public VkExternalSemaphoreHandleTypeFlags HandleType;
}