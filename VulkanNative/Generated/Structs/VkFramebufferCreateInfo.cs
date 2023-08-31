using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkFramebufferCreateFlags flags;
    public VkRenderPass renderPass;
    public uint attachmentCount;
    public VkImageView* pAttachments;
    public uint width;
    public uint height;
    public uint layers;
}