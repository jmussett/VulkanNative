using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Ycbcr2plane444Formats;
}