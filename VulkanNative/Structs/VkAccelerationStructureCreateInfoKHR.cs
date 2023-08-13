using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureCreateFlagsKHR CreateFlags;
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
    public VkAccelerationStructureTypeKHR Type;
    public VkDeviceAddress DeviceAddress;
}