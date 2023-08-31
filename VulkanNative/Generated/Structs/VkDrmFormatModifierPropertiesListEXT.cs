using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint drmFormatModifierCount;
    public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;

    public VkDrmFormatModifierPropertiesListEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT;
    }
}