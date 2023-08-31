using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 conditionalRendering;
    public VkBool32 inheritedConditionalRendering;
}