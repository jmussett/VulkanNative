namespace VulkanNative;

public unsafe class VkIntelPerformanceQueryExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> vkInitializePerformanceApiINTEL;
    public delegate* unmanaged[Cdecl]<VkDevice, void> vkUninitializePerformanceApiINTEL;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceMarkerINTEL;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceStreamMarkerINTEL;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> vkCmdSetPerformanceOverrideINTEL;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> vkAcquirePerformanceConfigurationINTEL;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult> vkReleasePerformanceConfigurationINTEL;
    public delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> vkQueueSetPerformanceConfigurationINTEL;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> vkGetPerformanceParameterINTEL;
}