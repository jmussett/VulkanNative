using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderSubgroupUniformControlFlow;

    public VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR;
    }
}