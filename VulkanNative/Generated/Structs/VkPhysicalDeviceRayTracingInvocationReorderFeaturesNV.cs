using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingInvocationReorder;

    public VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV;
    }
}