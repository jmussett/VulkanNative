using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureKHR accelerationStructure;

    public VkAccelerationStructureDeviceAddressInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR;
    }
}