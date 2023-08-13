using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint AspectReferenceCount;
    public VkInputAttachmentAspectReference* PAspectReferences;
}