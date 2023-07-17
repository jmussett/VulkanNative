using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyDescriptorSet
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorSet srcSet;
    public uint srcBinding;
    public uint srcArrayElement;
    public VkDescriptorSet dstSet;
    public uint dstBinding;
    public uint dstArrayElement;
    public uint descriptorCount;
}