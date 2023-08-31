using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPass renderPass;
    public uint subpass;
    public VkFramebuffer framebuffer;
    public VkBool32 occlusionQueryEnable;
    public VkQueryControlFlags queryFlags;
    public VkQueryPipelineStatisticFlags pipelineStatistics;
}