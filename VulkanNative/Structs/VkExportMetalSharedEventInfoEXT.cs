using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalSharedEventInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public VkEvent Event;
    public MTLSharedEvent_id MtlSharedEvent;
}