using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreateInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPassCreateFlags flags;
    public uint attachmentCount;
    public VkAttachmentDescription2* pAttachments;
    public uint subpassCount;
    public VkSubpassDescription2* pSubpasses;
    public uint dependencyCount;
    public VkSubpassDependency2* pDependencies;
    public uint correlatedViewMaskCount;
    public uint* pCorrelatedViewMasks;
}