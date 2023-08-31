using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkAttachmentReference fragmentDensityMapAttachment;
}