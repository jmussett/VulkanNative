using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRenderingCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint ViewMask;
    public uint ColorAttachmentCount;
    public VkFormat* PColorAttachmentFormats;
    public VkFormat DepthAttachmentFormat;
    public VkFormat StencilAttachmentFormat;
}