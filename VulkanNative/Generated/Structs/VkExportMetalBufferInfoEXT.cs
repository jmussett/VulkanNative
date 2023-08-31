using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalBufferInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public MTLBuffer_id mtlBuffer;

    public VkExportMetalBufferInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT;
    }
}