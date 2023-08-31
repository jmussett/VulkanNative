using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderDrawParameters;

    public VkPhysicalDeviceShaderDrawParametersFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES;
    }
}