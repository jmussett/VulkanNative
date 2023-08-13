using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 DepthBiasControl;
    public VkBool32 LeastRepresentableValueForceUnormRepresentation;
    public VkBool32 FloatRepresentation;
    public VkBool32 DepthBiasExact;
}