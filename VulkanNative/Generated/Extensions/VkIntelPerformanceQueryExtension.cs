using VulkanNative.Abstractions;
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

    public VkIntelPerformanceQueryExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkInitializePerformanceApiINTEL = (delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkInitializePerformanceApiINTEL");
        _vkUninitializePerformanceApiINTEL = (delegate* unmanaged[Cdecl]<VkDevice, void>)loader.GetDeviceProcAddr(device, "vkUninitializePerformanceApiINTEL");
        _vkCmdSetPerformanceMarkerINTEL = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkCmdSetPerformanceMarkerINTEL");
        _vkCmdSetPerformanceStreamMarkerINTEL = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkCmdSetPerformanceStreamMarkerINTEL");
        _vkCmdSetPerformanceOverrideINTEL = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkCmdSetPerformanceOverrideINTEL");
        _vkAcquirePerformanceConfigurationINTEL = (delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquirePerformanceConfigurationINTEL");
        _vkReleasePerformanceConfigurationINTEL = (delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult>)loader.GetDeviceProcAddr(device, "vkReleasePerformanceConfigurationINTEL");
        _vkQueueSetPerformanceConfigurationINTEL = (delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)loader.GetDeviceProcAddr(device, "vkQueueSetPerformanceConfigurationINTEL");
        _vkGetPerformanceParameterINTEL = (delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPerformanceParameterINTEL");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
    {
        return _vkInitializePerformanceApiINTEL(device, pInitializeInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkUninitializePerformanceApiINTEL(VkDevice device)
    {
        _vkUninitializePerformanceApiINTEL(device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
    {
        return _vkCmdSetPerformanceMarkerINTEL(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
    {
        return _vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
    {
        return _vkCmdSetPerformanceOverrideINTEL(commandBuffer, pOverrideInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
    {
        return _vkAcquirePerformanceConfigurationINTEL(device, pAcquireInfo, pConfiguration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
    {
        return _vkReleasePerformanceConfigurationINTEL(device, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
    {
        return _vkQueueSetPerformanceConfigurationINTEL(queue, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
    {
        return _vkGetPerformanceParameterINTEL(device, parameter, pValue);
    }
}