using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyDescriptorSet
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorSet SrcSet;
    public uint SrcBinding;
    public uint SrcArrayElement;
    public VkDescriptorSet DstSet;
    public uint DstBinding;
    public uint DstArrayElement;
    public uint DescriptorCount;
}