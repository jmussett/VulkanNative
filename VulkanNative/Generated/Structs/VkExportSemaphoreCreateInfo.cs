using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportSemaphoreCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalSemaphoreHandleTypeFlags handleTypes;

    public VkExportSemaphoreCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO;
    }
}