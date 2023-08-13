using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalCommandQueueInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkQueue Queue;
    public MTLCommandQueue_id MtlCommandQueue;
}