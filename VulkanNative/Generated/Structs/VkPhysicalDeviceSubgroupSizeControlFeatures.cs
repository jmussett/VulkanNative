using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 subgroupSizeControl;
    public VkBool32 computeFullSubgroups;

    public VkPhysicalDeviceSubgroupSizeControlFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES;
    }
}