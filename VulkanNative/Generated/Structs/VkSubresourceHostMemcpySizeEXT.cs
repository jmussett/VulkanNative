using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceHostMemcpySizeEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize size;
}