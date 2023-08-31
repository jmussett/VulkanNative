using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageSubresourceInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateInfo* pCreateInfo;
    public VkImageSubresource2KHR* pSubresource;
}