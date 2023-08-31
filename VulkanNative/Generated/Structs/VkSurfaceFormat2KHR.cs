using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFormat2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceFormatKHR surfaceFormat;
}