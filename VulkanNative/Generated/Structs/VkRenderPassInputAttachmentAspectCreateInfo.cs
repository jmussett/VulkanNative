using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint aspectReferenceCount;
    public VkInputAttachmentAspectReference* pAspectReferences;
}