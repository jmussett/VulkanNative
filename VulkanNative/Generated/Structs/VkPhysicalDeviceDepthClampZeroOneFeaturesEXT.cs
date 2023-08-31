using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 depthClampZeroOne;

    public VkPhysicalDeviceDepthClampZeroOneFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT;
    }
}