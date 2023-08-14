using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 TaskShader;
    public VkBool32 MeshShader;
}