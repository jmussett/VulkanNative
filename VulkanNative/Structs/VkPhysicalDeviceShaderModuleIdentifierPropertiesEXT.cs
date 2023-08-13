using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte ShaderModuleIdentifierAlgorithmUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
}