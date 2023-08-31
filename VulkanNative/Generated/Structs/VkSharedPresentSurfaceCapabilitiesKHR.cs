using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags sharedPresentSupportedUsageFlags;
}