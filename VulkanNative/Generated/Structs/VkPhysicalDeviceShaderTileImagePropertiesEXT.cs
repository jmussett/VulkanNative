using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderTileImagePropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderTileImageCoherentReadAccelerated;
    public VkBool32 shaderTileImageReadSampleFromPixelRateInvocation;
    public VkBool32 shaderTileImageReadFromHelperInvocation;

    public VkPhysicalDeviceShaderTileImagePropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT;
    }
}