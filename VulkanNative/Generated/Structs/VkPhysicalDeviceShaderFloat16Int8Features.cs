using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderFloat16;
    public VkBool32 shaderInt8;

    public VkPhysicalDeviceShaderFloat16Int8Features()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES;
    }
}