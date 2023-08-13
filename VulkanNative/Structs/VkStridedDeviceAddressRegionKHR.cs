using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStridedDeviceAddressRegionKHR
{
    public VkDeviceAddress DeviceAddress;
    public VkDeviceSize Stride;
    public VkDeviceSize Size;
}