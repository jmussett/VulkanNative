using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBinding
{
    public uint binding;
    public VkDescriptorType descriptorType;
    public uint descriptorCount;
    public VkShaderStageFlags stageFlags;
    public VkSampler* pImmutableSamplers;
}