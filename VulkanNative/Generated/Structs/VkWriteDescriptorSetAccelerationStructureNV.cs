using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint accelerationStructureCount;
    public VkAccelerationStructureNV* pAccelerationStructures;

    public VkWriteDescriptorSetAccelerationStructureNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV;
    }
}