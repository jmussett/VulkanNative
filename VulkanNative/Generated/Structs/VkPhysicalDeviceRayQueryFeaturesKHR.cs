using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayQuery;

    public VkPhysicalDeviceRayQueryFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR;
    }
}