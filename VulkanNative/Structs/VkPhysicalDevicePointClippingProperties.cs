using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePointClippingProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkPointClippingBehavior PointClippingBehavior;
}