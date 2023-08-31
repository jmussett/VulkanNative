using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
    public uint activeComputeUnitCount;

    public VkPhysicalDeviceShaderCoreProperties2AMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD;
    }
}