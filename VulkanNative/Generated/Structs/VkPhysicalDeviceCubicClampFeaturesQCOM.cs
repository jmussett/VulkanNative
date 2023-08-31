using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCubicClampFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 cubicRangeClamp;

    public VkPhysicalDeviceCubicClampFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM;
    }
}