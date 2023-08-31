using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreZirconHandleInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkSemaphoreImportFlags flags;
    public VkExternalSemaphoreHandleTypeFlags handleType;
    public nint zirconHandle;

    public VkImportSemaphoreZirconHandleInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA;
    }
}