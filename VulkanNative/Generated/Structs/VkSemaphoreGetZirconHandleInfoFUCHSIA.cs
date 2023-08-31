using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreGetZirconHandleInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkExternalSemaphoreHandleTypeFlags handleType;

    public VkSemaphoreGetZirconHandleInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA;
    }
}