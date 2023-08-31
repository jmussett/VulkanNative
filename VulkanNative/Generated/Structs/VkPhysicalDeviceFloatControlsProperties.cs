using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderFloatControlsIndependence denormBehaviorIndependence;
    public VkShaderFloatControlsIndependence roundingModeIndependence;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
    public VkBool32 shaderDenormPreserveFloat16;
    public VkBool32 shaderDenormPreserveFloat32;
    public VkBool32 shaderDenormPreserveFloat64;
    public VkBool32 shaderDenormFlushToZeroFloat16;
    public VkBool32 shaderDenormFlushToZeroFloat32;
    public VkBool32 shaderDenormFlushToZeroFloat64;
    public VkBool32 shaderRoundingModeRTEFloat16;
    public VkBool32 shaderRoundingModeRTEFloat32;
    public VkBool32 shaderRoundingModeRTEFloat64;
    public VkBool32 shaderRoundingModeRTZFloat16;
    public VkBool32 shaderRoundingModeRTZFloat32;
    public VkBool32 shaderRoundingModeRTZFloat64;

    public VkPhysicalDeviceFloatControlsProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES;
    }
}