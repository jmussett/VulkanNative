using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentModeEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPresentModeKHR presentMode;
}