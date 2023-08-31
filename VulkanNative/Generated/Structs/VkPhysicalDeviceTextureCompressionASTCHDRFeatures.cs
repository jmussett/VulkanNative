using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 textureCompressionASTC_HDR;

    public VkPhysicalDeviceTextureCompressionASTCHDRFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES;
    }
}