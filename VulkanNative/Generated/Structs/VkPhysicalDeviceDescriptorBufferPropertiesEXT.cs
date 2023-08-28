using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 CombinedImageSamplerDescriptorSingleArray;
    public VkBool32 BufferlessPushDescriptors;
    public VkBool32 AllowSamplerImageViewPostSubmitCreation;
    public VkDeviceSize DescriptorBufferOffsetAlignment;
    public uint MaxDescriptorBufferBindings;
    public uint MaxResourceDescriptorBufferBindings;
    public uint MaxSamplerDescriptorBufferBindings;
    public uint MaxEmbeddedImmutableSamplerBindings;
    public uint MaxEmbeddedImmutableSamplers;
    public nuint BufferCaptureReplayDescriptorDataSize;
    public nuint ImageCaptureReplayDescriptorDataSize;
    public nuint ImageViewCaptureReplayDescriptorDataSize;
    public nuint SamplerCaptureReplayDescriptorDataSize;
    public nuint AccelerationStructureCaptureReplayDescriptorDataSize;
    public nuint SamplerDescriptorSize;
    public nuint CombinedImageSamplerDescriptorSize;
    public nuint SampledImageDescriptorSize;
    public nuint StorageImageDescriptorSize;
    public nuint UniformTexelBufferDescriptorSize;
    public nuint RobustUniformTexelBufferDescriptorSize;
    public nuint StorageTexelBufferDescriptorSize;
    public nuint RobustStorageTexelBufferDescriptorSize;
    public nuint UniformBufferDescriptorSize;
    public nuint RobustUniformBufferDescriptorSize;
    public nuint StorageBufferDescriptorSize;
    public nuint RobustStorageBufferDescriptorSize;
    public nuint InputAttachmentDescriptorSize;
    public nuint AccelerationStructureDescriptorSize;
    public VkDeviceSize MaxSamplerDescriptorBufferRange;
    public VkDeviceSize MaxResourceDescriptorBufferRange;
    public VkDeviceSize SamplerDescriptorBufferAddressSpaceSize;
    public VkDeviceSize ResourceDescriptorBufferAddressSpaceSize;
    public VkDeviceSize DescriptorBufferAddressSpaceSize;
}