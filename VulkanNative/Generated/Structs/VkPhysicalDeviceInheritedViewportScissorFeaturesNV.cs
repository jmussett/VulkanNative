using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 inheritedViewportScissor2D;

    public VkPhysicalDeviceInheritedViewportScissorFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV;
    }
}