using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 dedicatedAllocationImageAliasing;

    public VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV;
    }
}