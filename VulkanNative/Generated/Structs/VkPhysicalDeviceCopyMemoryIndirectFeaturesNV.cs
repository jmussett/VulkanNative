using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 indirectCopy;

    public VkPhysicalDeviceCopyMemoryIndirectFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV;
    }
}