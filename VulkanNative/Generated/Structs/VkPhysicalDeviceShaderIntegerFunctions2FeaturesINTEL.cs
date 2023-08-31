using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderIntegerFunctions2;
}