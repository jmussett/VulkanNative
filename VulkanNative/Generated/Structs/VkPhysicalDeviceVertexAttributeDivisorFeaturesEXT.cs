using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 vertexAttributeInstanceRateDivisor;
    public VkBool32 vertexAttributeInstanceRateZeroDivisor;

    public VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT;
    }
}