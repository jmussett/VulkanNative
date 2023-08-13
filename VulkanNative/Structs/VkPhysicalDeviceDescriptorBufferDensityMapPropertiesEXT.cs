using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public nint CombinedImageSamplerDensityMapDescriptorSize;
}