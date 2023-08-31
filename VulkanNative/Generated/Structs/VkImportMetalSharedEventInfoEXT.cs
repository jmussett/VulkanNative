using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalSharedEventInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public MTLSharedEvent_id mtlSharedEvent;
}