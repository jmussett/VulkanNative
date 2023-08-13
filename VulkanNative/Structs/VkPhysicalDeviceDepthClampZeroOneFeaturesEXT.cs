using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 DepthClampZeroOne;
}