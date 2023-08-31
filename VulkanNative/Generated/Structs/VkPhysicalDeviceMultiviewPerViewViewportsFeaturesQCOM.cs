using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multiviewPerViewViewports;

    public VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM;
    }
}