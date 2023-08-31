using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlanePropertiesKHR
{
    public VkDisplayKHR currentDisplay;
    public uint currentStackIndex;
}