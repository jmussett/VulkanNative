using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectsInfoEXT
{
    public VkStructureType sType;
    public void* pNext;

    public VkExportMetalObjectsInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT;
    }
}