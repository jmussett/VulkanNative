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
    public nint BufferCaptureReplayDescriptorDataSize;
    public nint ImageCaptureReplayDescriptorDataSize;
    public nint ImageViewCaptureReplayDescriptorDataSize;
    public nint SamplerCaptureReplayDescriptorDataSize;
    public nint AccelerationStructureCaptureReplayDescriptorDataSize;
    public nint SamplerDescriptorSize;
    public nint CombinedImageSamplerDescriptorSize;
    public nint SampledImageDescriptorSize;
    public nint StorageImageDescriptorSize;
    public nint UniformTexelBufferDescriptorSize;
    public nint RobustUniformTexelBufferDescriptorSize;
    public nint StorageTexelBufferDescriptorSize;
    public nint RobustStorageTexelBufferDescriptorSize;
    public nint UniformBufferDescriptorSize;
    public nint RobustUniformBufferDescriptorSize;
    public nint StorageBufferDescriptorSize;
    public nint RobustStorageBufferDescriptorSize;
    public nint InputAttachmentDescriptorSize;
    public nint AccelerationStructureDescriptorSize;
    public VkDeviceSize MaxSamplerDescriptorBufferRange;
    public VkDeviceSize MaxResourceDescriptorBufferRange;
    public VkDeviceSize SamplerDescriptorBufferAddressSpaceSize;
    public VkDeviceSize ResourceDescriptorBufferAddressSpaceSize;
    public VkDeviceSize DescriptorBufferAddressSpaceSize;
}