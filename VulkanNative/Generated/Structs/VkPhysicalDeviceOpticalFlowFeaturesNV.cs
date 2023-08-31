using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpticalFlowFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 opticalFlow;

    public VkPhysicalDeviceOpticalFlowFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV;
    }
}