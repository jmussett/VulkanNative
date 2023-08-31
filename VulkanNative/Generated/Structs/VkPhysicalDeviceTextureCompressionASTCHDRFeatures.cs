using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 textureCompressionASTC_HDR;
}