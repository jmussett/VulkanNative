using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 TaskShader;
    public VkBool32 MeshShader;
    public VkBool32 MultiviewMeshShader;
    public VkBool32 PrimitiveFragmentShadingRateMeshShader;
    public VkBool32 MeshShaderQueries;
}