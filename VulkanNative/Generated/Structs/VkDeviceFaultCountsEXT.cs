using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultCountsEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint addressInfoCount;
    public uint vendorInfoCount;
    public VkDeviceSize vendorBinarySize;
}