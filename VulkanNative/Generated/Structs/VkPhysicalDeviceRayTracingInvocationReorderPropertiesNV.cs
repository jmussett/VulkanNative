using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkRayTracingInvocationReorderModeNV RayTracingInvocationReorderReorderingHint;
}