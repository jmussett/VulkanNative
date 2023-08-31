using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 clustercullingShader;
    public VkBool32 multiviewClusterCullingShader;

    public VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI;
    }
}