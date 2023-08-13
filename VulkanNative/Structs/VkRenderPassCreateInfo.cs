using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPassCreateFlags Flags;
    public uint AttachmentCount;
    public VkAttachmentDescription* PAttachments;
    public uint SubpassCount;
    public VkSubpassDescription* PSubpasses;
    public uint DependencyCount;
    public VkSubpassDependency* PDependencies;
}