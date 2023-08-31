using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 perViewPositionAllComponents;

    public VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX;
    }
}