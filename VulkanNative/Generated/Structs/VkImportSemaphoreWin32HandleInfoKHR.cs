using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkSemaphoreImportFlags flags;
    public VkExternalSemaphoreHandleTypeFlags handleType;
    public nint handle;
    public nint name;
}