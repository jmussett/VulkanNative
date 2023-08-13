using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderBufferFloat16Atomics;
    public VkBool32 ShaderBufferFloat16AtomicAdd;
    public VkBool32 ShaderBufferFloat16AtomicMinMax;
    public VkBool32 ShaderBufferFloat32AtomicMinMax;
    public VkBool32 ShaderBufferFloat64AtomicMinMax;
    public VkBool32 ShaderSharedFloat16Atomics;
    public VkBool32 ShaderSharedFloat16AtomicAdd;
    public VkBool32 ShaderSharedFloat16AtomicMinMax;
    public VkBool32 ShaderSharedFloat32AtomicMinMax;
    public VkBool32 ShaderSharedFloat64AtomicMinMax;
    public VkBool32 ShaderImageFloat32AtomicMinMax;
    public VkBool32 SparseImageFloat32AtomicMinMax;
}