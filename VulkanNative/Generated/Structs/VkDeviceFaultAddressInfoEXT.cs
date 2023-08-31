using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultAddressInfoEXT
{
    public VkDeviceFaultAddressTypeEXT addressType;
    public VkDeviceAddress reportedAddress;
    public VkDeviceSize addressPrecision;
}