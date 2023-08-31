using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint accelerationStructureCount;
    public VkAccelerationStructureKHR* pAccelerationStructures;

    public VkWriteDescriptorSetAccelerationStructureKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR;
    }
}