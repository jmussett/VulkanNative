using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FragmentShaderSampleInterlock;
    public VkBool32 FragmentShaderPixelInterlock;
    public VkBool32 FragmentShaderShadingRateInterlock;
}