using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorSetLayoutCreateFlags Flags;
    public uint BindingCount;
    public VkDescriptorSetLayoutBinding* PBindings;
}