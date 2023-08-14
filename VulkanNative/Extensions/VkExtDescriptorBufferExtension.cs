namespace VulkanNative;

public unsafe class VkExtDescriptorBufferExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkDeviceSize*, void> vkGetDescriptorSetLayoutSizeEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, uint, VkDeviceSize*, void> vkGetDescriptorSetLayoutBindingOffsetEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nint, void*, void> vkGetDescriptorEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void> vkCmdBindDescriptorBuffersEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, VkDeviceSize*, void> vkCmdSetDescriptorBufferOffsetsEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> vkCmdBindDescriptorBufferEmbeddedSamplersEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetBufferOpaqueCaptureDescriptorDataEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetImageOpaqueCaptureDescriptorDataEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetImageViewOpaqueCaptureDescriptorDataEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetSamplerOpaqueCaptureDescriptorDataEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;
}