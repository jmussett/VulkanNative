using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalBufferInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public MTLBuffer_id mtlBuffer;

    public VkImportMetalBufferInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT;
    }
}