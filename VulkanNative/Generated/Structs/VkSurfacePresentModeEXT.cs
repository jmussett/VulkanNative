using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentModeEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPresentModeKHR PresentMode;
}