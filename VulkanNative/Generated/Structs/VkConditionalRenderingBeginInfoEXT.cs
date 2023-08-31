using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkConditionalRenderingFlagsEXT flags;

    public VkConditionalRenderingBeginInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT;
    }
}