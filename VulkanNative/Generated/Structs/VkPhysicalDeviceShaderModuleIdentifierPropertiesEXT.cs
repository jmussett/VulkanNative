using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte shaderModuleIdentifierAlgorithmUUID[(int)VulkanApiConstants.VK_UUID_SIZE];

    public VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT;
    }
}