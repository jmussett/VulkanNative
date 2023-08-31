using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStridedDeviceAddressRegionKHR
{
    public VkDeviceAddress deviceAddress;
    public VkDeviceSize stride;
    public VkDeviceSize size;
}