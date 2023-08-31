using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte shaderModuleIdentifierAlgorithmUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
}