using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint drmFormatModifierCount;
    public ulong* pDrmFormatModifiers;

    public VkImageDrmFormatModifierListCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT;
    }
}