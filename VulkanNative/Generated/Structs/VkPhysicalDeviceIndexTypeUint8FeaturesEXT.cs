using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 IndexTypeUint8;
}