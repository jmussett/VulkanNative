using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 presentBarrier;

    public VkPhysicalDevicePresentBarrierFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV;
    }
}