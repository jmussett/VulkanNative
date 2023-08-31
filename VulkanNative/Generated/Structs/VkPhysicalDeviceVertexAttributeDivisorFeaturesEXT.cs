using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 vertexAttributeInstanceRateDivisor;
    public VkBool32 vertexAttributeInstanceRateZeroDivisor;
}