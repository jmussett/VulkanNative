using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandPoolMemoryConsumption
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize commandPoolAllocated;
    public VkDeviceSize commandPoolReservedSize;
    public VkDeviceSize commandBufferAllocated;
}