using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressConstKHR
{
    [FieldOffset(0)]
    public VkDeviceAddress deviceAddress;
    [FieldOffset(0)]
    public void* hostAddress;
}