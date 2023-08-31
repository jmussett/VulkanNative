using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public ulong drmFormatModifier;

    public VkImageDrmFormatModifierPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT;
    }
}