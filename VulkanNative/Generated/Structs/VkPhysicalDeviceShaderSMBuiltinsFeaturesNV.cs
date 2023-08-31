using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderSMBuiltins;

    public VkPhysicalDeviceShaderSMBuiltinsFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV;
    }
}