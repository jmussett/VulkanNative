using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint shaderSMCount;
    public uint shaderWarpsPerSM;

    public VkPhysicalDeviceShaderSMBuiltinsPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV;
    }
}