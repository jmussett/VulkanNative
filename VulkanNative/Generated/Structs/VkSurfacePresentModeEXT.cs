using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentModeEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPresentModeKHR presentMode;

    public VkSurfacePresentModeEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT;
    }
}