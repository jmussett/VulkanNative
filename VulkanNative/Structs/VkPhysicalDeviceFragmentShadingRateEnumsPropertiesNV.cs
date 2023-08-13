using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkSampleCountFlags MaxFragmentShadingRateInvocationCount;
}