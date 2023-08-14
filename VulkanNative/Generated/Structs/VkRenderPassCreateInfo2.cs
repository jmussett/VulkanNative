using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreateInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPassCreateFlags Flags;
    public uint AttachmentCount;
    public VkAttachmentDescription2* PAttachments;
    public uint SubpassCount;
    public VkSubpassDescription2* PSubpasses;
    public uint DependencyCount;
    public VkSubpassDependency2* PDependencies;
    public uint CorrelatedViewMaskCount;
    public uint* PCorrelatedViewMasks;
}