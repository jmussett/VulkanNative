using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureNV AccelerationStructure;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
    public uint DeviceIndexCount;
    public uint* PDeviceIndices;
}