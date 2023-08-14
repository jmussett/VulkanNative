using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FragmentDensityMapDeferred;
}