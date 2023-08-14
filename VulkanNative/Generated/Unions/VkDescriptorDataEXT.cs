using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDescriptorDataEXT
{
    [FieldOffset(0)]
    public VkSampler* PSampler;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* PCombinedImageSampler;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* PInputAttachmentImage;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* PSampledImage;
    [FieldOffset(0)]
    public VkDescriptorImageInfo* PStorageImage;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* PUniformTexelBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* PStorageTexelBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* PUniformBuffer;
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* PStorageBuffer;
    [FieldOffset(0)]
    public VkDeviceAddress AccelerationStructure;
}