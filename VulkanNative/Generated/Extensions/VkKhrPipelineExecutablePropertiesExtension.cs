using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrPipelineExecutablePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> _vkGetPipelineExecutablePropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> _vkGetPipelineExecutableStatisticsKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> _vkGetPipelineExecutableInternalRepresentationsKHR;

    public VkKhrPipelineExecutablePropertiesExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPipelineExecutablePropertiesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPipelineExecutablePropertiesKHR");
        _vkGetPipelineExecutableStatisticsKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPipelineExecutableStatisticsKHR");
        _vkGetPipelineExecutableInternalRepresentationsKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPipelineExecutableInternalRepresentationsKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
    {
        return _vkGetPipelineExecutablePropertiesKHR(device, pPipelineInfo, pExecutableCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
    {
        return _vkGetPipelineExecutableStatisticsKHR(device, pExecutableInfo, pStatisticCount, pStatistics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
    {
        return _vkGetPipelineExecutableInternalRepresentationsKHR(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
    }
}