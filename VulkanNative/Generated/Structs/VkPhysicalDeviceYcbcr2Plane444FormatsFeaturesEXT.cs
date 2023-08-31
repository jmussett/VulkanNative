using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 ycbcr2plane444Formats;
}