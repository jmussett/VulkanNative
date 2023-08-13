using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSet
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorSet DstSet;
    public uint DstBinding;
    public uint DstArrayElement;
    public uint DescriptorCount;
    public VkDescriptorType DescriptorType;
    public VkDescriptorImageInfo* PImageInfo;
    public VkDescriptorBufferInfo* PBufferInfo;
    public VkBufferView* PTexelBufferView;
}