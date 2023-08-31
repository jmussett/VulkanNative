using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderingFlags flags;
    public uint viewMask;
    public uint colorAttachmentCount;
    public VkFormat* pColorAttachmentFormats;
    public VkFormat depthAttachmentFormat;
    public VkFormat stencilAttachmentFormat;
    public VkSampleCountFlags rasterizationSamples;

    public VkCommandBufferInheritanceRenderingInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO;
    }
}