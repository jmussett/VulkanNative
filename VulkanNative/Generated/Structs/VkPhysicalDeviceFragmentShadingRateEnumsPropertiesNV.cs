using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
}