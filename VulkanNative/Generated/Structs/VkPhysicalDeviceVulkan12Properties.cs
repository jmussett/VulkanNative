using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
    public VkStructureType sType;
    public void* pNext;
    public VkDriverId driverID;
    public fixed byte driverName[(int)VulkanApiConstants.VK_MAX_DRIVER_NAME_SIZE];
    public fixed byte driverInfo[(int)VulkanApiConstants.VK_MAX_DRIVER_INFO_SIZE];
    public VkConformanceVersion conformanceVersion;
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
    public uint maxUpdateAfterBindDescriptorsInAllPools;
    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
    public VkBool32 robustBufferAccessUpdateAfterBind;
    public VkBool32 quadDivergentImplicitLod;
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
    public uint maxPerStageUpdateAfterBindResources;
    public uint maxDescriptorSetUpdateAfterBindSamplers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindSampledImages;
    public uint maxDescriptorSetUpdateAfterBindStorageImages;
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;
    public VkResolveModeFlags supportedDepthResolveModes;
    public VkResolveModeFlags supportedStencilResolveModes;
    public VkBool32 independentResolveNone;
    public VkBool32 independentResolve;
    public VkBool32 filterMinmaxSingleComponentFormats;
    public VkBool32 filterMinmaxImageComponentMapping;
    public ulong maxTimelineSemaphoreValueDifference;
    public VkSampleCountFlags framebufferIntegerColorSampleCounts;

    public VkPhysicalDeviceVulkan12Properties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES;
    }
}