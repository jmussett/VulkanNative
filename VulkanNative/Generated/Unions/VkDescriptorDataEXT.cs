using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDescriptorDataEXT
{
    [FieldOffset(0)]
    public VkSampler* pSampler;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pCombinedImageSampler;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pInputAttachmentImage;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pSampledImage;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pStorageImage;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pUniformBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pStorageBuffer;
    [FieldOffset(0)]
    public VkDeviceAddress accelerationStructure;
}