using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 selectableCubicWeights;

    public VkPhysicalDeviceCubicWeightsFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM;
    }
}