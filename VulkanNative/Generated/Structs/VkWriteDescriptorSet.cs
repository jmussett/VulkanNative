using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSet
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorSet dstSet;
    public uint dstBinding;
    public uint dstArrayElement;
    public uint descriptorCount;
    public VkDescriptorType descriptorType;
    public VkDescriptorImageInfo* pImageInfo;
    public VkDescriptorBufferInfo* pBufferInfo;
    public VkBufferView* pTexelBufferView;

    public VkWriteDescriptorSet()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;
    }
}