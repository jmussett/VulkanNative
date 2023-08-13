using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderIntegerFunctions2;
}