using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderIntegerDotProduct;

    public VkPhysicalDeviceShaderIntegerDotProductFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES;
    }
}