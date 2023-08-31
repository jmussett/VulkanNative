using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint accelerationStructureCount;
    public VkAccelerationStructureNV* pAccelerationStructures;
}