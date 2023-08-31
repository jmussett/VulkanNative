using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalSharedEventInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public MTLSharedEvent_id mtlSharedEvent;

    public VkImportMetalSharedEventInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT;
    }
}