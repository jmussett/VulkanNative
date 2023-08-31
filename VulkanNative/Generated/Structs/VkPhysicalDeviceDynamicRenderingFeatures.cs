using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 dynamicRendering;

    public VkPhysicalDeviceDynamicRenderingFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES;
    }
}