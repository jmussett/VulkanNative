using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 conditionalRenderingEnable;
}