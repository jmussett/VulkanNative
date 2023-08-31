using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 conditionalRenderingEnable;

    public VkCommandBufferInheritanceConditionalRenderingInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT;
    }
}