using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreFdInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public VkSemaphoreImportFlags Flags;
    public VkExternalSemaphoreHandleTypeFlags HandleType;
    public nint Fd;
}