using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 VulkanMemoryModel;
    public VkBool32 VulkanMemoryModelDeviceScope;
    public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
}