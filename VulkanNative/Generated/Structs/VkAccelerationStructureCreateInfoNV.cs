using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize CompactedSize;
    public VkAccelerationStructureInfoNV Info;
}