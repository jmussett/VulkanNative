using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPlaneCapabilitiesKHR capabilities;

    public VkDisplayPlaneCapabilities2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR;
    }
}