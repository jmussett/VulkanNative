using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePointClippingProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkPointClippingBehavior pointClippingBehavior;

    public VkPhysicalDevicePointClippingProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES;
    }
}