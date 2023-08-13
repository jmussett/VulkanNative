using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorPool DescriptorPool;
    public uint DescriptorSetCount;
    public VkDescriptorSetLayout* PSetLayouts;
}