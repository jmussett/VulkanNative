using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolSize
{
    public VkDescriptorType type;
    public uint descriptorCount;
}