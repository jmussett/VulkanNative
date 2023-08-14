using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public VkSemaphoreImportFlags Flags;
    public VkExternalSemaphoreHandleTypeFlags HandleType;
    public nint Handle;
    public nint Name;
}