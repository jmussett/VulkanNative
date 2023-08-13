using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderFloat16;
    public VkBool32 ShaderInt8;
}