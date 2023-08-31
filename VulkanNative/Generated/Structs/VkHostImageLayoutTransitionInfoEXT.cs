using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageLayoutTransitionInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public VkImageLayout oldLayout;
    public VkImageLayout newLayout;
    public VkImageSubresourceRange subresourceRange;

    public VkHostImageLayoutTransitionInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT;
    }
}