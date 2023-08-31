using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 taskShader;
    public VkBool32 meshShader;
}