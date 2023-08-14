using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultAddressInfoEXT
{
    public VkDeviceFaultAddressTypeEXT AddressType;
    public VkDeviceAddress ReportedAddress;
    public VkDeviceSize AddressPrecision;
}