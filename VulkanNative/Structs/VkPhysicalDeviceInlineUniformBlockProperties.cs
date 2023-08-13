using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxInlineUniformBlockSize;
    public uint MaxPerStageDescriptorInlineUniformBlocks;
    public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    public uint MaxDescriptorSetInlineUniformBlocks;
    public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}