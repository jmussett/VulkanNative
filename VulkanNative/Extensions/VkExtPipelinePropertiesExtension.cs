namespace VulkanNative;

public unsafe class VkExtPipelinePropertiesExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> vkGetPipelinePropertiesEXT;
}