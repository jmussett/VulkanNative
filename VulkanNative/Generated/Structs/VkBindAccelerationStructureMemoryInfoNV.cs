using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureNV accelerationStructure;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
    public uint deviceIndexCount;
    public uint* pDeviceIndices;
}