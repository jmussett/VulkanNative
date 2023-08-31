using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint drmFormatModifierCount;
    public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;

    public VkDrmFormatModifierPropertiesList2EXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT;
    }
}