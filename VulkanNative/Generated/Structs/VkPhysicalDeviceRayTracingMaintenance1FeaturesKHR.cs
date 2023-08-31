using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingMaintenance1;
    public VkBool32 rayTracingPipelineTraceRaysIndirect2;
}