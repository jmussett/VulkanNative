using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multiviewPerViewRenderAreas;

    public VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM;
    }
}