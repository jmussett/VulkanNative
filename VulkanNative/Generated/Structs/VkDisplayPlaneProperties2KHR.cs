using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneProperties2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPlanePropertiesKHR displayPlaneProperties;

    public VkDisplayPlaneProperties2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR;
    }
}