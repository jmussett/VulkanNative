using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
    public VkStructureType SType;
    public void* PNext;
    public VkDriverId DriverID;
    public fixed byte DriverName[(int)VulkanApiConstants.VK_MAX_DRIVER_NAME_SIZE];
    public fixed byte DriverInfo[(int)VulkanApiConstants.VK_MAX_DRIVER_INFO_SIZE];
    public VkConformanceVersion ConformanceVersion;
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
    public uint MaxUpdateAfterBindDescriptorsInAllPools;
    public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative;
    public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative;
    public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative;
    public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative;
    public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
    public VkBool32 RobustBufferAccessUpdateAfterBind;
    public VkBool32 QuadDivergentImplicitLod;
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
    public uint MaxPerStageUpdateAfterBindResources;
    public uint MaxDescriptorSetUpdateAfterBindSamplers;
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
    public VkResolveModeFlags SupportedDepthResolveModes;
    public VkResolveModeFlags SupportedStencilResolveModes;
    public VkBool32 IndependentResolveNone;
    public VkBool32 IndependentResolve;
    public VkBool32 FilterMinmaxSingleComponentFormats;
    public VkBool32 FilterMinmaxImageComponentMapping;
    public ulong MaxTimelineSemaphoreValueDifference;
    public VkSampleCountFlags FramebufferIntegerColorSampleCounts;
}