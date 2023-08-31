using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 depthClipEnable;

    public VkPhysicalDeviceDepthClipEnableFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT;
    }
}