using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderIntegerFunctions2;

    public VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL;
    }
}