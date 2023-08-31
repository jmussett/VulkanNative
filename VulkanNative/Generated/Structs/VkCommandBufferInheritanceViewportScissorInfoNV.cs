using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 viewportScissor2D;
    public uint viewportDepthCount;
    public VkViewport* pViewportDepths;

    public VkCommandBufferInheritanceViewportScissorInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV;
    }
}