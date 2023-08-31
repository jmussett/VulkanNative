using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint minSubgroupSize;
    public uint maxSubgroupSize;
    public uint maxComputeWorkgroupSubgroups;
    public VkShaderStageFlags requiredSubgroupSizeStages;

    public VkPhysicalDeviceSubgroupSizeControlProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES;
    }
}