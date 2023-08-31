using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fullScreenExclusiveSupported;

    public VkSurfaceCapabilitiesFullScreenExclusiveEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT;
    }
}