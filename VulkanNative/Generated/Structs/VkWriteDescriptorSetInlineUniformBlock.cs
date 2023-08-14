using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
    public VkStructureType SType;
    public void* PNext;
    public uint DataSize;
    public void* PData;
}