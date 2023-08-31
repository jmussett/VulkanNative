using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 clustercullingShader;
    public VkBool32 multiviewClusterCullingShader;
}