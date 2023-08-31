using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 taskShader;
    public VkBool32 meshShader;
    public VkBool32 multiviewMeshShader;
    public VkBool32 primitiveFragmentShadingRateMeshShader;
    public VkBool32 meshShaderQueries;
}