using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 deviceCoherentMemory;

    public VkPhysicalDeviceCoherentMemoryFeaturesAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD;
    }
}