using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalSharedEventInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public VkEvent @event;
    public MTLSharedEvent_id mtlSharedEvent;

    public VkExportMetalSharedEventInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT;
    }
}