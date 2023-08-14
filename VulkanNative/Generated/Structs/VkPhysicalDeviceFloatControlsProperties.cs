using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderFloatControlsIndependence DenormBehaviorIndependence;
    public VkShaderFloatControlsIndependence RoundingModeIndependence;
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat16;
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat32;
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat64;
    public VkBool32 ShaderDenormPreserveFloat16;
    public VkBool32 ShaderDenormPreserveFloat32;
    public VkBool32 ShaderDenormPreserveFloat64;
    public VkBool32 ShaderDenormFlushToZeroFloat16;
    public VkBool32 ShaderDenormFlushToZeroFloat32;
    public VkBool32 ShaderDenormFlushToZeroFloat64;
    public VkBool32 ShaderRoundingModeRTEFloat16;
    public VkBool32 ShaderRoundingModeRTEFloat32;
    public VkBool32 ShaderRoundingModeRTEFloat64;
    public VkBool32 ShaderRoundingModeRTZFloat16;
    public VkBool32 ShaderRoundingModeRTZFloat32;
    public VkBool32 ShaderRoundingModeRTZFloat64;
}