using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderObjectFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderObject;

    public VkPhysicalDeviceShaderObjectFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT;
    }
}