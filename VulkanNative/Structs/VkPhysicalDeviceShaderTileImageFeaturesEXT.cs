using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderTileImageFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderTileImageColorReadAccess;
    public VkBool32 ShaderTileImageDepthReadAccess;
    public VkBool32 ShaderTileImageStencilReadAccess;
}