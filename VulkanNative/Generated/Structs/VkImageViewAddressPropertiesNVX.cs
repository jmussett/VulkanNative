using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewAddressPropertiesNVX
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceAddress DeviceAddress;
    public VkDeviceSize Size;
}