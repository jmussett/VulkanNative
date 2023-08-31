using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags sharedPresentSupportedUsageFlags;

    public VkSharedPresentSurfaceCapabilitiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR;
    }
}