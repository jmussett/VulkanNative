using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingMaintenance1;
    public VkBool32 rayTracingPipelineTraceRaysIndirect2;

    public VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR;
    }
}