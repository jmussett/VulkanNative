using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxInlineUniformBlockSize;
    public uint maxPerStageDescriptorInlineUniformBlocks;
    public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    public uint maxDescriptorSetInlineUniformBlocks;
    public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}