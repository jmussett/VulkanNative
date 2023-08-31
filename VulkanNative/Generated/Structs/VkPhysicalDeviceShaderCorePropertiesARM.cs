using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCorePropertiesARM
{
    public VkStructureType sType;
    public void* pNext;
    public uint pixelRate;
    public uint texelRate;
    public uint fmaRate;

    public VkPhysicalDeviceShaderCorePropertiesARM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM;
    }
}