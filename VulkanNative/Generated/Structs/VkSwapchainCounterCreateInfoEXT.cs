using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceCounterFlagsEXT surfaceCounters;
}