using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ConditionalRendering;
    public VkBool32 InheritedConditionalRendering;
}