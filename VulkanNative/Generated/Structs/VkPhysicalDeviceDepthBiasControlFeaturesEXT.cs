using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 depthBiasControl;
    public VkBool32 leastRepresentableValueForceUnormRepresentation;
    public VkBool32 floatRepresentation;
    public VkBool32 depthBiasExact;

    public VkPhysicalDeviceDepthBiasControlFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT;
    }
}