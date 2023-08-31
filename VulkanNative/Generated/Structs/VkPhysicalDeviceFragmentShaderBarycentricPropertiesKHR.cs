using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 triStripVertexOrderIndependentOfProvokingVertex;

    public VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR;
    }
}