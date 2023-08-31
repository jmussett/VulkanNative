using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalCommandQueueInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueue queue;
    public MTLCommandQueue_id mtlCommandQueue;

    public VkExportMetalCommandQueueInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT;
    }
}