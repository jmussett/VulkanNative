using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderBufferInt64Atomics;
    public VkBool32 shaderSharedInt64Atomics;
}