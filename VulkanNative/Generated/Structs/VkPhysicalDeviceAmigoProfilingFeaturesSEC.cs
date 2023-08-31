using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 amigoProfiling;

    public VkPhysicalDeviceAmigoProfilingFeaturesSEC()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC;
    }
}