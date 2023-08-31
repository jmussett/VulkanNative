using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint subgroupSize;
    public VkShaderStageFlags supportedStages;
    public VkSubgroupFeatureFlags supportedOperations;
    public VkBool32 quadOperationsInAllStages;

    public VkPhysicalDeviceSubgroupProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES;
    }
}