using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FormatRgba10x6WithoutYCbCrSampler;
}