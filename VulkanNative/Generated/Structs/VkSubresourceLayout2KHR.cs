using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceLayout2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSubresourceLayout subresourceLayout;

    public VkSubresourceLayout2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR;
    }
}