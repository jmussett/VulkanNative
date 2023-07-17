using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPass renderPass;
    public VkFramebuffer framebuffer;
    public VkRect2D renderArea;
    public uint clearValueCount;
    public VkClearValue* pClearValues;
}