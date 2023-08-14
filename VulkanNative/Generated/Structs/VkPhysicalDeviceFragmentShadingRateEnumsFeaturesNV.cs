using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FragmentShadingRateEnums;
    public VkBool32 SupersampleFragmentShadingRates;
    public VkBool32 NoInvocationFragmentShadingRates;
}