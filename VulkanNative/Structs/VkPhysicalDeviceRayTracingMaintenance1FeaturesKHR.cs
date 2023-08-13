using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RayTracingMaintenance1;
    public VkBool32 RayTracingPipelineTraceRaysIndirect2;
}