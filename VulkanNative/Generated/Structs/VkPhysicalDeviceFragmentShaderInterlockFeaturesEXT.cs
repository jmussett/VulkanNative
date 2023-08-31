using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentShaderSampleInterlock;
    public VkBool32 fragmentShaderPixelInterlock;
    public VkBool32 fragmentShaderShadingRateInterlock;
}