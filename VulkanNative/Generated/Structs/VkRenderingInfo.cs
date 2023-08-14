using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderingFlags Flags;
    public VkRect2D RenderArea;
    public uint LayerCount;
    public uint ViewMask;
    public uint ColorAttachmentCount;
    public VkRenderingAttachmentInfo* PColorAttachments;
    public VkRenderingAttachmentInfo* PDepthAttachment;
    public VkRenderingAttachmentInfo* PStencilAttachment;
}