using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint aspectReferenceCount;
    public VkInputAttachmentAspectReference* pAspectReferences;

    public VkRenderPassInputAttachmentAspectCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO;
    }
}