using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 taskShader;
    public VkBool32 meshShader;

    public VkPhysicalDeviceMeshShaderFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV;
    }
}