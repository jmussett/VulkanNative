using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderCoreBuiltins;

    public VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM;
    }
}