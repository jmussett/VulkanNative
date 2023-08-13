using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageSubresourceInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCreateInfo* PCreateInfo;
    public VkImageSubresource2KHR* PSubresource;
}