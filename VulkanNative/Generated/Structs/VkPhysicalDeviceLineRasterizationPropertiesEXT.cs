using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint LineSubPixelPrecisionBits;
}