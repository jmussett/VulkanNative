using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SubgroupSizeControl;
    public VkBool32 ComputeFullSubgroups;
}