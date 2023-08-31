using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneInfo2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayModeKHR mode;
    public uint planeIndex;

    public VkDisplayPlaneInfo2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR;
    }
}