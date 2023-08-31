using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderBufferFloat32Atomics;
    public VkBool32 shaderBufferFloat32AtomicAdd;
    public VkBool32 shaderBufferFloat64Atomics;
    public VkBool32 shaderBufferFloat64AtomicAdd;
    public VkBool32 shaderSharedFloat32Atomics;
    public VkBool32 shaderSharedFloat32AtomicAdd;
    public VkBool32 shaderSharedFloat64Atomics;
    public VkBool32 shaderSharedFloat64AtomicAdd;
    public VkBool32 shaderImageFloat32Atomics;
    public VkBool32 shaderImageFloat32AtomicAdd;
    public VkBool32 sparseImageFloat32Atomics;
    public VkBool32 sparseImageFloat32AtomicAdd;
}