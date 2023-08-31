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

    public VkImportSemaphoreWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR;
    }
}