using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderObjectPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte shaderBinaryUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public uint shaderBinaryVersion;

    public VkPhysicalDeviceShaderObjectPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT;
    }
}