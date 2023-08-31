using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;

    public VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV;
    }
}