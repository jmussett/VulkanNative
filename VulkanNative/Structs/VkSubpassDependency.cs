using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDependency
{
    public uint SrcSubpass;
    public uint DstSubpass;
    public VkPipelineStageFlags SrcStageMask;
    public VkPipelineStageFlags DstStageMask;
    public VkAccessFlags SrcAccessMask;
    public VkAccessFlags DstAccessMask;
    public VkDependencyFlags DependencyFlags;
}