using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 extendedDynamicState2;
    public VkBool32 extendedDynamicState2LogicOp;
    public VkBool32 extendedDynamicState2PatchControlPoints;
}