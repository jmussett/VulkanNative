using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
}