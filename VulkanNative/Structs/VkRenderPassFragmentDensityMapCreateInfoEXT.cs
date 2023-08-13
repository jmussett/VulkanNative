using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkAttachmentReference FragmentDensityMapAttachment;
}