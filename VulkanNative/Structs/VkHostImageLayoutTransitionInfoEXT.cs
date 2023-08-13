using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageLayoutTransitionInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
    public VkImageLayout OldLayout;
    public VkImageLayout NewLayout;
    public VkImageSubresourceRange SubresourceRange;
}