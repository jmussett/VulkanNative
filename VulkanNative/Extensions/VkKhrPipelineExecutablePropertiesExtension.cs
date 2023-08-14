namespace VulkanNative;

public unsafe class VkKhrPipelineExecutablePropertiesExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> vkGetPipelineExecutablePropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> vkGetPipelineExecutableStatisticsKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> vkGetPipelineExecutableInternalRepresentationsKHR;
}