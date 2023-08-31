using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 computeDerivativeGroupQuads;
    public VkBool32 computeDerivativeGroupLinear;

    public VkPhysicalDeviceComputeShaderDerivativesFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV;
    }
}