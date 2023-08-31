using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderBufferFloat16Atomics;
    public VkBool32 shaderBufferFloat16AtomicAdd;
    public VkBool32 shaderBufferFloat16AtomicMinMax;
    public VkBool32 shaderBufferFloat32AtomicMinMax;
    public VkBool32 shaderBufferFloat64AtomicMinMax;
    public VkBool32 shaderSharedFloat16Atomics;
    public VkBool32 shaderSharedFloat16AtomicAdd;
    public VkBool32 shaderSharedFloat16AtomicMinMax;
    public VkBool32 shaderSharedFloat32AtomicMinMax;
    public VkBool32 shaderSharedFloat64AtomicMinMax;
    public VkBool32 shaderImageFloat32AtomicMinMax;
    public VkBool32 sparseImageFloat32AtomicMinMax;

    public VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT;
    }
}