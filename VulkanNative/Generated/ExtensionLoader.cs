using VulkanNative.Abstractions;

namespace VulkanNative;

public class ExtensionLoader
{
    private readonly IFunctionLoader _functionLoader;

    public ExtensionLoader(IFunctionLoader functionLoader)
    {
        _functionLoader = functionLoader;
    }

    public VkKhrSurfaceExtension LoadVkKhrSurfaceExtension(VkInstance instance)
    {
        return new VkKhrSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrSwapchainExtension LoadVkKhrSwapchainExtension(VkDevice device)
    {
        return new VkKhrSwapchainExtension(device, _functionLoader);
    }

    public VkKhrDisplayExtension LoadVkKhrDisplayExtension(VkInstance instance)
    {
        return new VkKhrDisplayExtension(instance, _functionLoader);
    }

    public VkKhrDisplaySwapchainExtension LoadVkKhrDisplaySwapchainExtension(VkDevice device)
    {
        return new VkKhrDisplaySwapchainExtension(device, _functionLoader);
    }

    public VkKhrXlibSurfaceExtension LoadVkKhrXlibSurfaceExtension(VkInstance instance)
    {
        return new VkKhrXlibSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrXcbSurfaceExtension LoadVkKhrXcbSurfaceExtension(VkInstance instance)
    {
        return new VkKhrXcbSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrWaylandSurfaceExtension LoadVkKhrWaylandSurfaceExtension(VkInstance instance)
    {
        return new VkKhrWaylandSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrAndroidSurfaceExtension LoadVkKhrAndroidSurfaceExtension(VkInstance instance)
    {
        return new VkKhrAndroidSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrWin32SurfaceExtension LoadVkKhrWin32SurfaceExtension(VkInstance instance)
    {
        return new VkKhrWin32SurfaceExtension(instance, _functionLoader);
    }

    public VkExtDebugMarkerExtension LoadVkExtDebugMarkerExtension(VkDevice device)
    {
        return new VkExtDebugMarkerExtension(device, _functionLoader);
    }

    public VkKhrVideoQueueExtension LoadVkKhrVideoQueueExtension(VkDevice device)
    {
        return new VkKhrVideoQueueExtension(device, _functionLoader);
    }

    public VkKhrVideoDecodeQueueExtension LoadVkKhrVideoDecodeQueueExtension(VkDevice device)
    {
        return new VkKhrVideoDecodeQueueExtension(device, _functionLoader);
    }

    public VkExtTransformFeedbackExtension LoadVkExtTransformFeedbackExtension(VkDevice device)
    {
        return new VkExtTransformFeedbackExtension(device, _functionLoader);
    }

    public VkNvxBinaryImportExtension LoadVkNvxBinaryImportExtension(VkDevice device)
    {
        return new VkNvxBinaryImportExtension(device, _functionLoader);
    }

    public VkNvxImageViewHandleExtension LoadVkNvxImageViewHandleExtension(VkDevice device)
    {
        return new VkNvxImageViewHandleExtension(device, _functionLoader);
    }

    public VkAmdDrawIndirectCountExtension LoadVkAmdDrawIndirectCountExtension(VkDevice device)
    {
        return new VkAmdDrawIndirectCountExtension(device, _functionLoader);
    }

    public VkAmdShaderInfoExtension LoadVkAmdShaderInfoExtension(VkDevice device)
    {
        return new VkAmdShaderInfoExtension(device, _functionLoader);
    }

    public VkKhrDynamicRenderingExtension LoadVkKhrDynamicRenderingExtension(VkDevice device)
    {
        return new VkKhrDynamicRenderingExtension(device, _functionLoader);
    }

    public VkGgpStreamDescriptorSurfaceExtension LoadVkGgpStreamDescriptorSurfaceExtension(VkInstance instance)
    {
        return new VkGgpStreamDescriptorSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrGetPhysicalDeviceProperties2Extension LoadVkKhrGetPhysicalDeviceProperties2Extension(VkInstance instance)
    {
        return new VkKhrGetPhysicalDeviceProperties2Extension(instance, _functionLoader);
    }

    public VkKhrDeviceGroupExtension LoadVkKhrDeviceGroupExtension(VkDevice device)
    {
        return new VkKhrDeviceGroupExtension(device, _functionLoader);
    }

    public VkNnViSurfaceExtension LoadVkNnViSurfaceExtension(VkInstance instance)
    {
        return new VkNnViSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrMaintenance1Extension LoadVkKhrMaintenance1Extension(VkDevice device)
    {
        return new VkKhrMaintenance1Extension(device, _functionLoader);
    }

    public VkKhrDeviceGroupCreationExtension LoadVkKhrDeviceGroupCreationExtension(VkInstance instance)
    {
        return new VkKhrDeviceGroupCreationExtension(instance, _functionLoader);
    }

    public VkKhrExternalMemoryCapabilitiesExtension LoadVkKhrExternalMemoryCapabilitiesExtension(VkInstance instance)
    {
        return new VkKhrExternalMemoryCapabilitiesExtension(instance, _functionLoader);
    }

    public VkKhrExternalMemoryWin32Extension LoadVkKhrExternalMemoryWin32Extension(VkDevice device)
    {
        return new VkKhrExternalMemoryWin32Extension(device, _functionLoader);
    }

    public VkKhrExternalMemoryFdExtension LoadVkKhrExternalMemoryFdExtension(VkDevice device)
    {
        return new VkKhrExternalMemoryFdExtension(device, _functionLoader);
    }

    public VkKhrExternalSemaphoreCapabilitiesExtension LoadVkKhrExternalSemaphoreCapabilitiesExtension(VkInstance instance)
    {
        return new VkKhrExternalSemaphoreCapabilitiesExtension(instance, _functionLoader);
    }

    public VkKhrExternalSemaphoreWin32Extension LoadVkKhrExternalSemaphoreWin32Extension(VkDevice device)
    {
        return new VkKhrExternalSemaphoreWin32Extension(device, _functionLoader);
    }

    public VkKhrExternalSemaphoreFdExtension LoadVkKhrExternalSemaphoreFdExtension(VkDevice device)
    {
        return new VkKhrExternalSemaphoreFdExtension(device, _functionLoader);
    }

    public VkKhrPushDescriptorExtension LoadVkKhrPushDescriptorExtension(VkDevice device)
    {
        return new VkKhrPushDescriptorExtension(device, _functionLoader);
    }

    public VkExtConditionalRenderingExtension LoadVkExtConditionalRenderingExtension(VkDevice device)
    {
        return new VkExtConditionalRenderingExtension(device, _functionLoader);
    }

    public VkKhrDescriptorUpdateTemplateExtension LoadVkKhrDescriptorUpdateTemplateExtension(VkDevice device)
    {
        return new VkKhrDescriptorUpdateTemplateExtension(device, _functionLoader);
    }

    public VkNvClipSpaceWScalingExtension LoadVkNvClipSpaceWScalingExtension(VkDevice device)
    {
        return new VkNvClipSpaceWScalingExtension(device, _functionLoader);
    }

    public VkExtDirectModeDisplayExtension LoadVkExtDirectModeDisplayExtension(VkInstance instance)
    {
        return new VkExtDirectModeDisplayExtension(instance, _functionLoader);
    }

    public VkExtAcquireXlibDisplayExtension LoadVkExtAcquireXlibDisplayExtension(VkInstance instance)
    {
        return new VkExtAcquireXlibDisplayExtension(instance, _functionLoader);
    }

    public VkExtDisplaySurfaceCounterExtension LoadVkExtDisplaySurfaceCounterExtension(VkInstance instance)
    {
        return new VkExtDisplaySurfaceCounterExtension(instance, _functionLoader);
    }

    public VkExtDisplayControlExtension LoadVkExtDisplayControlExtension(VkDevice device)
    {
        return new VkExtDisplayControlExtension(device, _functionLoader);
    }

    public VkGoogleDisplayTimingExtension LoadVkGoogleDisplayTimingExtension(VkDevice device)
    {
        return new VkGoogleDisplayTimingExtension(device, _functionLoader);
    }

    public VkExtDiscardRectanglesExtension LoadVkExtDiscardRectanglesExtension(VkDevice device)
    {
        return new VkExtDiscardRectanglesExtension(device, _functionLoader);
    }

    public VkExtHdrMetadataExtension LoadVkExtHdrMetadataExtension(VkDevice device)
    {
        return new VkExtHdrMetadataExtension(device, _functionLoader);
    }

    public VkKhrCreateRenderpass2Extension LoadVkKhrCreateRenderpass2Extension(VkDevice device)
    {
        return new VkKhrCreateRenderpass2Extension(device, _functionLoader);
    }

    public VkKhrSharedPresentableImageExtension LoadVkKhrSharedPresentableImageExtension(VkDevice device)
    {
        return new VkKhrSharedPresentableImageExtension(device, _functionLoader);
    }

    public VkKhrExternalFenceCapabilitiesExtension LoadVkKhrExternalFenceCapabilitiesExtension(VkInstance instance)
    {
        return new VkKhrExternalFenceCapabilitiesExtension(instance, _functionLoader);
    }

    public VkKhrExternalFenceWin32Extension LoadVkKhrExternalFenceWin32Extension(VkDevice device)
    {
        return new VkKhrExternalFenceWin32Extension(device, _functionLoader);
    }

    public VkKhrExternalFenceFdExtension LoadVkKhrExternalFenceFdExtension(VkDevice device)
    {
        return new VkKhrExternalFenceFdExtension(device, _functionLoader);
    }

    public VkKhrPerformanceQueryExtension LoadVkKhrPerformanceQueryExtension(VkDevice device)
    {
        return new VkKhrPerformanceQueryExtension(device, _functionLoader);
    }

    public VkKhrGetSurfaceCapabilities2Extension LoadVkKhrGetSurfaceCapabilities2Extension(VkInstance instance)
    {
        return new VkKhrGetSurfaceCapabilities2Extension(instance, _functionLoader);
    }

    public VkKhrGetDisplayProperties2Extension LoadVkKhrGetDisplayProperties2Extension(VkInstance instance)
    {
        return new VkKhrGetDisplayProperties2Extension(instance, _functionLoader);
    }

    public VkExtDebugUtilsExtension LoadVkExtDebugUtilsExtension(VkInstance instance)
    {
        return new VkExtDebugUtilsExtension(instance, _functionLoader);
    }

    public VkAndroidExternalMemoryAndroidHardwareBufferExtension LoadVkAndroidExternalMemoryAndroidHardwareBufferExtension(VkDevice device)
    {
        return new VkAndroidExternalMemoryAndroidHardwareBufferExtension(device, _functionLoader);
    }

    public VkExtSampleLocationsExtension LoadVkExtSampleLocationsExtension(VkDevice device)
    {
        return new VkExtSampleLocationsExtension(device, _functionLoader);
    }

    public VkKhrGetMemoryRequirements2Extension LoadVkKhrGetMemoryRequirements2Extension(VkDevice device)
    {
        return new VkKhrGetMemoryRequirements2Extension(device, _functionLoader);
    }

    public VkKhrAccelerationStructureExtension LoadVkKhrAccelerationStructureExtension(VkDevice device)
    {
        return new VkKhrAccelerationStructureExtension(device, _functionLoader);
    }

    public VkKhrRayTracingPipelineExtension LoadVkKhrRayTracingPipelineExtension(VkDevice device)
    {
        return new VkKhrRayTracingPipelineExtension(device, _functionLoader);
    }

    public VkKhrSamplerYcbcrConversionExtension LoadVkKhrSamplerYcbcrConversionExtension(VkDevice device)
    {
        return new VkKhrSamplerYcbcrConversionExtension(device, _functionLoader);
    }

    public VkKhrBindMemory2Extension LoadVkKhrBindMemory2Extension(VkDevice device)
    {
        return new VkKhrBindMemory2Extension(device, _functionLoader);
    }

    public VkExtImageDrmFormatModifierExtension LoadVkExtImageDrmFormatModifierExtension(VkDevice device)
    {
        return new VkExtImageDrmFormatModifierExtension(device, _functionLoader);
    }

    public VkExtValidationCacheExtension LoadVkExtValidationCacheExtension(VkDevice device)
    {
        return new VkExtValidationCacheExtension(device, _functionLoader);
    }

    public VkNvShadingRateImageExtension LoadVkNvShadingRateImageExtension(VkDevice device)
    {
        return new VkNvShadingRateImageExtension(device, _functionLoader);
    }

    public VkNvRayTracingExtension LoadVkNvRayTracingExtension(VkDevice device)
    {
        return new VkNvRayTracingExtension(device, _functionLoader);
    }

    public VkKhrMaintenance3Extension LoadVkKhrMaintenance3Extension(VkDevice device)
    {
        return new VkKhrMaintenance3Extension(device, _functionLoader);
    }

    public VkKhrDrawIndirectCountExtension LoadVkKhrDrawIndirectCountExtension(VkDevice device)
    {
        return new VkKhrDrawIndirectCountExtension(device, _functionLoader);
    }

    public VkExtExternalMemoryHostExtension LoadVkExtExternalMemoryHostExtension(VkDevice device)
    {
        return new VkExtExternalMemoryHostExtension(device, _functionLoader);
    }

    public VkAmdBufferMarkerExtension LoadVkAmdBufferMarkerExtension(VkDevice device)
    {
        return new VkAmdBufferMarkerExtension(device, _functionLoader);
    }

    public VkExtCalibratedTimestampsExtension LoadVkExtCalibratedTimestampsExtension(VkDevice device)
    {
        return new VkExtCalibratedTimestampsExtension(device, _functionLoader);
    }

    public VkNvMeshShaderExtension LoadVkNvMeshShaderExtension(VkDevice device)
    {
        return new VkNvMeshShaderExtension(device, _functionLoader);
    }

    public VkNvScissorExclusiveExtension LoadVkNvScissorExclusiveExtension(VkDevice device)
    {
        return new VkNvScissorExclusiveExtension(device, _functionLoader);
    }

    public VkNvDeviceDiagnosticCheckpointsExtension LoadVkNvDeviceDiagnosticCheckpointsExtension(VkDevice device)
    {
        return new VkNvDeviceDiagnosticCheckpointsExtension(device, _functionLoader);
    }

    public VkKhrTimelineSemaphoreExtension LoadVkKhrTimelineSemaphoreExtension(VkDevice device)
    {
        return new VkKhrTimelineSemaphoreExtension(device, _functionLoader);
    }

    public VkIntelPerformanceQueryExtension LoadVkIntelPerformanceQueryExtension(VkDevice device)
    {
        return new VkIntelPerformanceQueryExtension(device, _functionLoader);
    }

    public VkAmdDisplayNativeHdrExtension LoadVkAmdDisplayNativeHdrExtension(VkDevice device)
    {
        return new VkAmdDisplayNativeHdrExtension(device, _functionLoader);
    }

    public VkFuchsiaImagepipeSurfaceExtension LoadVkFuchsiaImagepipeSurfaceExtension(VkInstance instance)
    {
        return new VkFuchsiaImagepipeSurfaceExtension(instance, _functionLoader);
    }

    public VkExtMetalSurfaceExtension LoadVkExtMetalSurfaceExtension(VkInstance instance)
    {
        return new VkExtMetalSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrFragmentShadingRateExtension LoadVkKhrFragmentShadingRateExtension(VkDevice device)
    {
        return new VkKhrFragmentShadingRateExtension(device, _functionLoader);
    }

    public VkExtToolingInfoExtension LoadVkExtToolingInfoExtension(VkDevice device)
    {
        return new VkExtToolingInfoExtension(device, _functionLoader);
    }

    public VkKhrPresentWaitExtension LoadVkKhrPresentWaitExtension(VkDevice device)
    {
        return new VkKhrPresentWaitExtension(device, _functionLoader);
    }

    public VkNvCooperativeMatrixExtension LoadVkNvCooperativeMatrixExtension(VkDevice device)
    {
        return new VkNvCooperativeMatrixExtension(device, _functionLoader);
    }

    public VkNvCoverageReductionModeExtension LoadVkNvCoverageReductionModeExtension(VkDevice device)
    {
        return new VkNvCoverageReductionModeExtension(device, _functionLoader);
    }

    public VkExtFullScreenExclusiveExtension LoadVkExtFullScreenExclusiveExtension(VkDevice device)
    {
        return new VkExtFullScreenExclusiveExtension(device, _functionLoader);
    }

    public VkExtHeadlessSurfaceExtension LoadVkExtHeadlessSurfaceExtension(VkInstance instance)
    {
        return new VkExtHeadlessSurfaceExtension(instance, _functionLoader);
    }

    public VkKhrBufferDeviceAddressExtension LoadVkKhrBufferDeviceAddressExtension(VkDevice device)
    {
        return new VkKhrBufferDeviceAddressExtension(device, _functionLoader);
    }

    public VkExtLineRasterizationExtension LoadVkExtLineRasterizationExtension(VkDevice device)
    {
        return new VkExtLineRasterizationExtension(device, _functionLoader);
    }

    public VkExtHostQueryResetExtension LoadVkExtHostQueryResetExtension(VkDevice device)
    {
        return new VkExtHostQueryResetExtension(device, _functionLoader);
    }

    public VkExtExtendedDynamicStateExtension LoadVkExtExtendedDynamicStateExtension(VkDevice device)
    {
        return new VkExtExtendedDynamicStateExtension(device, _functionLoader);
    }

    public VkKhrDeferredHostOperationsExtension LoadVkKhrDeferredHostOperationsExtension(VkDevice device)
    {
        return new VkKhrDeferredHostOperationsExtension(device, _functionLoader);
    }

    public VkKhrPipelineExecutablePropertiesExtension LoadVkKhrPipelineExecutablePropertiesExtension(VkDevice device)
    {
        return new VkKhrPipelineExecutablePropertiesExtension(device, _functionLoader);
    }

    public VkExtHostImageCopyExtension LoadVkExtHostImageCopyExtension(VkDevice device)
    {
        return new VkExtHostImageCopyExtension(device, _functionLoader);
    }

    public VkKhrMapMemory2Extension LoadVkKhrMapMemory2Extension(VkDevice device)
    {
        return new VkKhrMapMemory2Extension(device, _functionLoader);
    }

    public VkExtSwapchainMaintenance1Extension LoadVkExtSwapchainMaintenance1Extension(VkDevice device)
    {
        return new VkExtSwapchainMaintenance1Extension(device, _functionLoader);
    }

    public VkNvDeviceGeneratedCommandsExtension LoadVkNvDeviceGeneratedCommandsExtension(VkDevice device)
    {
        return new VkNvDeviceGeneratedCommandsExtension(device, _functionLoader);
    }

    public VkExtDepthBiasControlExtension LoadVkExtDepthBiasControlExtension(VkDevice device)
    {
        return new VkExtDepthBiasControlExtension(device, _functionLoader);
    }

    public VkExtAcquireDrmDisplayExtension LoadVkExtAcquireDrmDisplayExtension(VkInstance instance)
    {
        return new VkExtAcquireDrmDisplayExtension(instance, _functionLoader);
    }

    public VkExtPrivateDataExtension LoadVkExtPrivateDataExtension(VkDevice device)
    {
        return new VkExtPrivateDataExtension(device, _functionLoader);
    }

    public VkExtMetalObjectsExtension LoadVkExtMetalObjectsExtension(VkDevice device)
    {
        return new VkExtMetalObjectsExtension(device, _functionLoader);
    }

    public VkKhrSynchronization2Extension LoadVkKhrSynchronization2Extension(VkDevice device)
    {
        return new VkKhrSynchronization2Extension(device, _functionLoader);
    }

    public VkExtDescriptorBufferExtension LoadVkExtDescriptorBufferExtension(VkDevice device)
    {
        return new VkExtDescriptorBufferExtension(device, _functionLoader);
    }

    public VkNvFragmentShadingRateEnumsExtension LoadVkNvFragmentShadingRateEnumsExtension(VkDevice device)
    {
        return new VkNvFragmentShadingRateEnumsExtension(device, _functionLoader);
    }

    public VkExtMeshShaderExtension LoadVkExtMeshShaderExtension(VkDevice device)
    {
        return new VkExtMeshShaderExtension(device, _functionLoader);
    }

    public VkKhrCopyCommands2Extension LoadVkKhrCopyCommands2Extension(VkDevice device)
    {
        return new VkKhrCopyCommands2Extension(device, _functionLoader);
    }

    public VkExtImageCompressionControlExtension LoadVkExtImageCompressionControlExtension(VkDevice device)
    {
        return new VkExtImageCompressionControlExtension(device, _functionLoader);
    }

    public VkExtDeviceFaultExtension LoadVkExtDeviceFaultExtension(VkDevice device)
    {
        return new VkExtDeviceFaultExtension(device, _functionLoader);
    }

    public VkNvAcquireWinrtDisplayExtension LoadVkNvAcquireWinrtDisplayExtension(VkDevice device)
    {
        return new VkNvAcquireWinrtDisplayExtension(device, _functionLoader);
    }

    public VkExtDirectfbSurfaceExtension LoadVkExtDirectfbSurfaceExtension(VkInstance instance)
    {
        return new VkExtDirectfbSurfaceExtension(instance, _functionLoader);
    }

    public VkExtVertexInputDynamicStateExtension LoadVkExtVertexInputDynamicStateExtension(VkDevice device)
    {
        return new VkExtVertexInputDynamicStateExtension(device, _functionLoader);
    }

    public VkFuchsiaExternalMemoryExtension LoadVkFuchsiaExternalMemoryExtension(VkDevice device)
    {
        return new VkFuchsiaExternalMemoryExtension(device, _functionLoader);
    }

    public VkFuchsiaExternalSemaphoreExtension LoadVkFuchsiaExternalSemaphoreExtension(VkDevice device)
    {
        return new VkFuchsiaExternalSemaphoreExtension(device, _functionLoader);
    }

    public VkFuchsiaBufferCollectionExtension LoadVkFuchsiaBufferCollectionExtension(VkDevice device)
    {
        return new VkFuchsiaBufferCollectionExtension(device, _functionLoader);
    }

    public VkHuaweiSubpassShadingExtension LoadVkHuaweiSubpassShadingExtension(VkDevice device)
    {
        return new VkHuaweiSubpassShadingExtension(device, _functionLoader);
    }

    public VkHuaweiInvocationMaskExtension LoadVkHuaweiInvocationMaskExtension(VkDevice device)
    {
        return new VkHuaweiInvocationMaskExtension(device, _functionLoader);
    }

    public VkNvExternalMemoryRdmaExtension LoadVkNvExternalMemoryRdmaExtension(VkDevice device)
    {
        return new VkNvExternalMemoryRdmaExtension(device, _functionLoader);
    }

    public VkExtPipelinePropertiesExtension LoadVkExtPipelinePropertiesExtension(VkDevice device)
    {
        return new VkExtPipelinePropertiesExtension(device, _functionLoader);
    }

    public VkExtExtendedDynamicState2Extension LoadVkExtExtendedDynamicState2Extension(VkDevice device)
    {
        return new VkExtExtendedDynamicState2Extension(device, _functionLoader);
    }

    public VkQnxScreenSurfaceExtension LoadVkQnxScreenSurfaceExtension(VkInstance instance)
    {
        return new VkQnxScreenSurfaceExtension(instance, _functionLoader);
    }

    public VkExtColorWriteEnableExtension LoadVkExtColorWriteEnableExtension(VkDevice device)
    {
        return new VkExtColorWriteEnableExtension(device, _functionLoader);
    }

    public VkKhrRayTracingMaintenance1Extension LoadVkKhrRayTracingMaintenance1Extension(VkDevice device)
    {
        return new VkKhrRayTracingMaintenance1Extension(device, _functionLoader);
    }

    public VkExtMultiDrawExtension LoadVkExtMultiDrawExtension(VkDevice device)
    {
        return new VkExtMultiDrawExtension(device, _functionLoader);
    }

    public VkExtOpacityMicromapExtension LoadVkExtOpacityMicromapExtension(VkDevice device)
    {
        return new VkExtOpacityMicromapExtension(device, _functionLoader);
    }

    public VkHuaweiClusterCullingShaderExtension LoadVkHuaweiClusterCullingShaderExtension(VkDevice device)
    {
        return new VkHuaweiClusterCullingShaderExtension(device, _functionLoader);
    }

    public VkExtPageableDeviceLocalMemoryExtension LoadVkExtPageableDeviceLocalMemoryExtension(VkDevice device)
    {
        return new VkExtPageableDeviceLocalMemoryExtension(device, _functionLoader);
    }

    public VkKhrMaintenance4Extension LoadVkKhrMaintenance4Extension(VkDevice device)
    {
        return new VkKhrMaintenance4Extension(device, _functionLoader);
    }

    public VkValveDescriptorSetHostMappingExtension LoadVkValveDescriptorSetHostMappingExtension(VkDevice device)
    {
        return new VkValveDescriptorSetHostMappingExtension(device, _functionLoader);
    }

    public VkNvCopyMemoryIndirectExtension LoadVkNvCopyMemoryIndirectExtension(VkDevice device)
    {
        return new VkNvCopyMemoryIndirectExtension(device, _functionLoader);
    }

    public VkNvMemoryDecompressionExtension LoadVkNvMemoryDecompressionExtension(VkDevice device)
    {
        return new VkNvMemoryDecompressionExtension(device, _functionLoader);
    }

    public VkNvDeviceGeneratedCommandsComputeExtension LoadVkNvDeviceGeneratedCommandsComputeExtension(VkDevice device)
    {
        return new VkNvDeviceGeneratedCommandsComputeExtension(device, _functionLoader);
    }

    public VkExtExtendedDynamicState3Extension LoadVkExtExtendedDynamicState3Extension(VkDevice device)
    {
        return new VkExtExtendedDynamicState3Extension(device, _functionLoader);
    }

    public VkExtShaderModuleIdentifierExtension LoadVkExtShaderModuleIdentifierExtension(VkDevice device)
    {
        return new VkExtShaderModuleIdentifierExtension(device, _functionLoader);
    }

    public VkNvOpticalFlowExtension LoadVkNvOpticalFlowExtension(VkDevice device)
    {
        return new VkNvOpticalFlowExtension(device, _functionLoader);
    }

    public VkKhrMaintenance5Extension LoadVkKhrMaintenance5Extension(VkDevice device)
    {
        return new VkKhrMaintenance5Extension(device, _functionLoader);
    }

    public VkExtShaderObjectExtension LoadVkExtShaderObjectExtension(VkDevice device)
    {
        return new VkExtShaderObjectExtension(device, _functionLoader);
    }

    public VkQcomTilePropertiesExtension LoadVkQcomTilePropertiesExtension(VkDevice device)
    {
        return new VkQcomTilePropertiesExtension(device, _functionLoader);
    }

    public VkKhrCooperativeMatrixExtension LoadVkKhrCooperativeMatrixExtension(VkDevice device)
    {
        return new VkKhrCooperativeMatrixExtension(device, _functionLoader);
    }

    public VkExtAttachmentFeedbackLoopDynamicStateExtension LoadVkExtAttachmentFeedbackLoopDynamicStateExtension(VkDevice device)
    {
        return new VkExtAttachmentFeedbackLoopDynamicStateExtension(device, _functionLoader);
    }

    public VkQnxExternalMemoryScreenBufferExtension LoadVkQnxExternalMemoryScreenBufferExtension(VkDevice device)
    {
        return new VkQnxExternalMemoryScreenBufferExtension(device, _functionLoader);
    }
}