using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 filterMinmaxSingleComponentFormats;
    public VkBool32 filterMinmaxImageComponentMapping;
}