using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D MinFragmentDensityTexelSize;
    public VkExtent2D MaxFragmentDensityTexelSize;
    public VkBool32 FragmentDensityInvocations;
}