using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 exclusiveScissor;

    public VkPhysicalDeviceExclusiveScissorFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV;
    }
}