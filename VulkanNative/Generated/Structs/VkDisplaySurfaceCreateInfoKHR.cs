using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplaySurfaceCreateFlagsKHR flags;
    public VkDisplayModeKHR displayMode;
    public uint planeIndex;
    public uint planeStackIndex;
    public VkSurfaceTransformFlagsKHR transform;
    public float globalAlpha;
    public VkDisplayPlaneAlphaFlagsKHR alphaMode;
    public VkExtent2D imageExtent;

    public VkDisplaySurfaceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR;
    }
}