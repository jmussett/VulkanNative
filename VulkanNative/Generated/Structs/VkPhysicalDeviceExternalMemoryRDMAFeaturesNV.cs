using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 externalMemoryRDMA;

    public VkPhysicalDeviceExternalMemoryRDMAFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV;
    }
}