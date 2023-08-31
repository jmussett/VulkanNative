using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 inheritedViewportScissor2D;
}