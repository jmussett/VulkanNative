using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolSize
{
    public VkDescriptorType Type;
    public uint DescriptorCount;
}