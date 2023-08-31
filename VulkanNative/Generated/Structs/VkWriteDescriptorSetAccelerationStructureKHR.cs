using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint accelerationStructureCount;
    public VkAccelerationStructureKHR* pAccelerationStructures;
}