using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fullScreenExclusiveSupported;
}