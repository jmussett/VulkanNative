using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeParametersKHR
{
    public VkExtent2D VisibleRegion;
    public uint RefreshRate;
}