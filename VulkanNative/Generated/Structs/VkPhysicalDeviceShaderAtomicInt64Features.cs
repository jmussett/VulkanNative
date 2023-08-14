using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderBufferInt64Atomics;
    public VkBool32 ShaderSharedInt64Atomics;
}