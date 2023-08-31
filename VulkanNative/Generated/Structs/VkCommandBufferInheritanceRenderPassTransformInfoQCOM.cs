using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceTransformFlagsKHR transform;
    public VkRect2D renderArea;

    public VkCommandBufferInheritanceRenderPassTransformInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM;
    }
}