using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageBlit2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageSubresourceLayers srcSubresource;
    public VkOffset3D* srcOffsets;
    public VkImageSubresourceLayers dstSubresource;
    public VkOffset3D* dstOffsets;

    public VkImageBlit2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_BLIT_2;
    }
}