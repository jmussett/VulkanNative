using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentModeCompatibilityEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint presentModeCount;
    public VkPresentModeKHR* pPresentModes;

    public VkSurfacePresentModeCompatibilityEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT;
    }
}