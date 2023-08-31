using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkExportMetalObjectTypeFlagsEXT exportObjectType;

    public VkExportMetalObjectCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT;
    }
}