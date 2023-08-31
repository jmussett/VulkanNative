using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilities2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceCapabilitiesKHR surfaceCapabilities;
}