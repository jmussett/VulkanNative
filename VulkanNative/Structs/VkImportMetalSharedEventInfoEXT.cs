using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalSharedEventInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public MTLSharedEvent_id MtlSharedEvent;
}