using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 depthClipControl;

    public VkPhysicalDeviceDepthClipControlFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT;
    }
}