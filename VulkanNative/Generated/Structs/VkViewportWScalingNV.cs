using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViewportWScalingNV
{
    public float xcoeff;
    public float ycoeff;
}