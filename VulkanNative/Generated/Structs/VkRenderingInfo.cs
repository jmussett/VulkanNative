using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderingFlags flags;
    public VkRect2D renderArea;
    public uint layerCount;
    public uint viewMask;
    public uint colorAttachmentCount;
    public VkRenderingAttachmentInfo* pColorAttachments;
    public VkRenderingAttachmentInfo* pDepthAttachment;
    public VkRenderingAttachmentInfo* pStencilAttachment;
}