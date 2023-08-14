using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPass RenderPass;
    public uint Subpass;
    public VkFramebuffer Framebuffer;
    public VkBool32 OcclusionQueryEnable;
    public VkQueryControlFlags QueryFlags;
    public VkQueryPipelineStatisticFlags PipelineStatistics;
}