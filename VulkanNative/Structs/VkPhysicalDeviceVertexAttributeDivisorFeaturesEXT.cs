using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 VertexAttributeInstanceRateDivisor;
    public VkBool32 VertexAttributeInstanceRateZeroDivisor;
}