using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkAttachmentReference fragmentDensityMapAttachment;

    public VkRenderPassFragmentDensityMapCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT;
    }
}