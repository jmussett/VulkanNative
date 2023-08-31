using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueueFlags supportedQueues;

    public VkPhysicalDeviceCopyMemoryIndirectPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV;
    }
}