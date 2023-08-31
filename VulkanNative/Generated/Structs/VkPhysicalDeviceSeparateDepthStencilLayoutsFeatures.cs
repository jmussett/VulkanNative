using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 separateDepthStencilLayouts;

    public VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES;
    }
}