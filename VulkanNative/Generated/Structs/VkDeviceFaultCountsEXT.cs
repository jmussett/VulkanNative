using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultCountsEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint AddressInfoCount;
    public uint VendorInfoCount;
    public VkDeviceSize VendorBinarySize;
}