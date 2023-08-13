using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte DeviceUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte DriverUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte DeviceLUID[(int)VulkanApiConstants.VK_LUID_SIZE];
    public uint DeviceNodeMask;
    public VkBool32 DeviceLUIDValid;
    public uint SubgroupSize;
    public VkShaderStageFlags SubgroupSupportedStages;
    public VkSubgroupFeatureFlags SubgroupSupportedOperations;
    public VkBool32 SubgroupQuadOperationsInAllStages;
    public VkPointClippingBehavior PointClippingBehavior;
    public uint MaxMultiviewViewCount;
    public uint MaxMultiviewInstanceIndex;
    public VkBool32 ProtectedNoFault;
    public uint MaxPerSetDescriptors;
    public VkDeviceSize MaxMemoryAllocationSize;
}