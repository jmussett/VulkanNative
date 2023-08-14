using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FilterMinmaxSingleComponentFormats;
    public VkBool32 FilterMinmaxImageComponentMapping;
}