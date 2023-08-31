using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 filterMinmaxSingleComponentFormats;
    public VkBool32 filterMinmaxImageComponentMapping;

    public VkPhysicalDeviceSamplerFilterMinmaxProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES;
    }
}