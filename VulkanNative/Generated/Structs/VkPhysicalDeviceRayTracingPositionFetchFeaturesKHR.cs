using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingPositionFetch;

    public VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR;
    }
}