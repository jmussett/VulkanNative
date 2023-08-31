using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 combinedImageSamplerDescriptorSingleArray;
    public VkBool32 bufferlessPushDescriptors;
    public VkBool32 allowSamplerImageViewPostSubmitCreation;
    public VkDeviceSize descriptorBufferOffsetAlignment;
    public uint maxDescriptorBufferBindings;
    public uint maxResourceDescriptorBufferBindings;
    public uint maxSamplerDescriptorBufferBindings;
    public uint maxEmbeddedImmutableSamplerBindings;
    public uint maxEmbeddedImmutableSamplers;
    public nuint bufferCaptureReplayDescriptorDataSize;
    public nuint imageCaptureReplayDescriptorDataSize;
    public nuint imageViewCaptureReplayDescriptorDataSize;
    public nuint samplerCaptureReplayDescriptorDataSize;
    public nuint accelerationStructureCaptureReplayDescriptorDataSize;
    public nuint samplerDescriptorSize;
    public nuint combinedImageSamplerDescriptorSize;
    public nuint sampledImageDescriptorSize;
    public nuint storageImageDescriptorSize;
    public nuint uniformTexelBufferDescriptorSize;
    public nuint robustUniformTexelBufferDescriptorSize;
    public nuint storageTexelBufferDescriptorSize;
    public nuint robustStorageTexelBufferDescriptorSize;
    public nuint uniformBufferDescriptorSize;
    public nuint robustUniformBufferDescriptorSize;
    public nuint storageBufferDescriptorSize;
    public nuint robustStorageBufferDescriptorSize;
    public nuint inputAttachmentDescriptorSize;
    public nuint accelerationStructureDescriptorSize;
    public VkDeviceSize maxSamplerDescriptorBufferRange;
    public VkDeviceSize maxResourceDescriptorBufferRange;
    public VkDeviceSize samplerDescriptorBufferAddressSpaceSize;
    public VkDeviceSize resourceDescriptorBufferAddressSpaceSize;
    public VkDeviceSize descriptorBufferAddressSpaceSize;

    public VkPhysicalDeviceDescriptorBufferPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT;
    }
}