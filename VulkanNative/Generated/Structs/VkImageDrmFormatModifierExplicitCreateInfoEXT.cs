using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public ulong drmFormatModifier;
    public uint drmFormatModifierPlaneCount;
    public VkSubresourceLayout* pPlaneLayouts;

    public VkImageDrmFormatModifierExplicitCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT;
    }
}