using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderBufferFloat32Atomics;
    public VkBool32 ShaderBufferFloat32AtomicAdd;
    public VkBool32 ShaderBufferFloat64Atomics;
    public VkBool32 ShaderBufferFloat64AtomicAdd;
    public VkBool32 ShaderSharedFloat32Atomics;
    public VkBool32 ShaderSharedFloat32AtomicAdd;
    public VkBool32 ShaderSharedFloat64Atomics;
    public VkBool32 ShaderSharedFloat64AtomicAdd;
    public VkBool32 ShaderImageFloat32Atomics;
    public VkBool32 ShaderImageFloat32AtomicAdd;
    public VkBool32 SparseImageFloat32Atomics;
    public VkBool32 SparseImageFloat32AtomicAdd;
}