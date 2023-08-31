using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewAddressPropertiesNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress deviceAddress;
    public VkDeviceSize size;
}