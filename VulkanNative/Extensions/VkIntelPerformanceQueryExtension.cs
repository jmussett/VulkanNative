using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkIntelPerformanceQueryExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> _vkInitializePerformanceApiINTEL;
    private delegate* unmanaged[Cdecl]<VkDevice, void> _vkUninitializePerformanceApiINTEL;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceMarkerINTEL;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceStreamMarkerINTEL;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> _vkCmdSetPerformanceOverrideINTEL;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> _vkAcquirePerformanceConfigurationINTEL;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult> _vkReleasePerformanceConfigurationINTEL;
    private delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> _vkQueueSetPerformanceConfigurationINTEL;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> _vkGetPerformanceParameterINTEL;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
    {
        return _vkInitializePerformanceApiINTEL(device, pInitializeInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkUninitializePerformanceApiINTEL(VkDevice device)
    {
        _vkUninitializePerformanceApiINTEL(device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
    {
        return _vkCmdSetPerformanceMarkerINTEL(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
    {
        return _vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
    {
        return _vkCmdSetPerformanceOverrideINTEL(commandBuffer, pOverrideInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
    {
        return _vkAcquirePerformanceConfigurationINTEL(device, pAcquireInfo, pConfiguration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
    {
        return _vkReleasePerformanceConfigurationINTEL(device, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
    {
        return _vkQueueSetPerformanceConfigurationINTEL(queue, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
    {
        return _vkGetPerformanceParameterINTEL(device, parameter, pValue);
    }
}