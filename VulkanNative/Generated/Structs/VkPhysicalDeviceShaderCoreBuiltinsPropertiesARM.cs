using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
    public VkStructureType sType;
    public void* pNext;
    public ulong shaderCoreMask;
    public uint shaderCoreCount;
    public uint shaderWarpsPerCore;

    public VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM;
    }
}