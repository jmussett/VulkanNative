using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 formatRgba10x6WithoutYCbCrSampler;
}