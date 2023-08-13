using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint SubgroupSize;
    public VkShaderStageFlags SupportedStages;
    public VkSubgroupFeatureFlags SupportedOperations;
    public VkBool32 QuadOperationsInAllStages;
}