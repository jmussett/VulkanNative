using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderTileImagePropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderTileImageCoherentReadAccelerated;
    public VkBool32 ShaderTileImageReadSampleFromPixelRateInvocation;
    public VkBool32 ShaderTileImageReadFromHelperInvocation;
}