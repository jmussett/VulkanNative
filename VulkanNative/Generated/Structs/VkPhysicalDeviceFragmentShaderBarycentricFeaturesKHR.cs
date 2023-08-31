using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentShaderBarycentric;

    public VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR;
    }
}