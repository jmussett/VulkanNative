using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresource2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageSubresource imageSubresource;

    public VkImageSubresource2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR;
    }
}