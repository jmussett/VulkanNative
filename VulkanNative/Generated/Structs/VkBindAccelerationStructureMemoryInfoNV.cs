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

    public VkBindAccelerationStructureMemoryInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV;
    }
}