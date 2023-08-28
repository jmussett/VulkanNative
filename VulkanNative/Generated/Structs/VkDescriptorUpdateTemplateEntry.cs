using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorUpdateTemplateEntry
{
    public uint DstBinding;
    public uint DstArrayElement;
    public uint DescriptorCount;
    public VkDescriptorType DescriptorType;
    public nuint Offset;
    public nuint Stride;
}