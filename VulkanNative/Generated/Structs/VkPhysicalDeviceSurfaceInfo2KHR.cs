using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceKHR surface;

    public VkPhysicalDeviceSurfaceInfo2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR;
    }
}