using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressKHR
{
    [FieldOffset(0)]
    public VkDeviceAddress deviceAddress;
    [FieldOffset(0)]
    public void* hostAddress;
}