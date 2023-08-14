using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ComputeDerivativeGroupQuads;
    public VkBool32 ComputeDerivativeGroupLinear;
}