using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBinding
{
    public uint Binding;
    public VkDescriptorType DescriptorType;
    public uint DescriptorCount;
    public VkShaderStageFlags StageFlags;
    public VkSampler* PImmutableSamplers;
}