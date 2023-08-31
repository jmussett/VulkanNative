using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderZeroInitializeWorkgroupMemory;

    public VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES;
    }
}