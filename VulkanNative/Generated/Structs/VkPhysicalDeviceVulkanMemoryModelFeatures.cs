using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 vulkanMemoryModel;
    public VkBool32 vulkanMemoryModelDeviceScope;
    public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;

    public VkPhysicalDeviceVulkanMemoryModelFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES;
    }
}