using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderModuleIdentifier;
}