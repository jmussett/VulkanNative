using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPassCreateFlags flags;
    public uint attachmentCount;
    public VkAttachmentDescription* pAttachments;
    public uint subpassCount;
    public VkSubpassDescription* pSubpasses;
    public uint dependencyCount;
    public VkSubpassDependency* pDependencies;
}