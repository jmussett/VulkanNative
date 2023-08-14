using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassBeginInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPass RenderPass;
    public VkFramebuffer Framebuffer;
    public VkRect2D RenderArea;
    public uint ClearValueCount;
    public VkClearValue* PClearValues;
}