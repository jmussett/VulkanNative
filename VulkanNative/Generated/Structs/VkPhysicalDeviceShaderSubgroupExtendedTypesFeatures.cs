using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderSubgroupExtendedTypes;

    public VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES;
    }
}