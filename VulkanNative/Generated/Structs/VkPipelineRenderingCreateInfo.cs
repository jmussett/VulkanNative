using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRenderingCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint viewMask;
    public uint colorAttachmentCount;
    public VkFormat* pColorAttachmentFormats;
    public VkFormat depthAttachmentFormat;
    public VkFormat stencilAttachmentFormat;

    public VkPipelineRenderingCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO;
    }
}