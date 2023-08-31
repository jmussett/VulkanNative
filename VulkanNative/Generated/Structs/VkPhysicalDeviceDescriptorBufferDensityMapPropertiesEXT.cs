using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public nuint combinedImageSamplerDensityMapDescriptorSize;

    public VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT;
    }
}