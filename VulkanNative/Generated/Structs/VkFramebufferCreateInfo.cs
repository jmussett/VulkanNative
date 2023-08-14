using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkFramebufferCreateFlags Flags;
    public VkRenderPass RenderPass;
    public uint AttachmentCount;
    public VkImageView* PAttachments;
    public uint Width;
    public uint Height;
    public uint Layers;
}