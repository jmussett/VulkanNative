using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderImageInt64Atomics;
    public VkBool32 sparseImageInt64Atomics;
}