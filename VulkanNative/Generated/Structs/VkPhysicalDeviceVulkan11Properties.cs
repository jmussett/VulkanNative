using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte deviceUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte driverUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte deviceLUID[(int)VulkanApiConstants.VK_LUID_SIZE];
    public uint deviceNodeMask;
    public VkBool32 deviceLUIDValid;
    public uint subgroupSize;
    public VkShaderStageFlags subgroupSupportedStages;
    public VkSubgroupFeatureFlags subgroupSupportedOperations;
    public VkBool32 subgroupQuadOperationsInAllStages;
    public VkPointClippingBehavior pointClippingBehavior;
    public uint maxMultiviewViewCount;
    public uint maxMultiviewInstanceIndex;
    public VkBool32 protectedNoFault;
    public uint maxPerSetDescriptors;
    public VkDeviceSize maxMemoryAllocationSize;

    public VkPhysicalDeviceVulkan11Properties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES;
    }
}