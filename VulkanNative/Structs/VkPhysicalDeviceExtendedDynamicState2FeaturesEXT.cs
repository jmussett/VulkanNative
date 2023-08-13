using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ExtendedDynamicState2;
    public VkBool32 ExtendedDynamicState2LogicOp;
    public VkBool32 ExtendedDynamicState2PatchControlPoints;
}