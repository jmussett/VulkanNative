using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceHostMemcpySizeEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize size;

    public VkSubresourceHostMemcpySizeEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT;
    }
}