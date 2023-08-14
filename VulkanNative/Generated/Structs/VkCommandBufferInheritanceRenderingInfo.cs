using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderingFlags Flags;
    public uint ViewMask;
    public uint ColorAttachmentCount;
    public VkFormat* PColorAttachmentFormats;
    public VkFormat DepthAttachmentFormat;
    public VkFormat StencilAttachmentFormat;
    public VkSampleCountFlags RasterizationSamples;
}