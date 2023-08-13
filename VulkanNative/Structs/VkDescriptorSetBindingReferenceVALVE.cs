using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorSetLayout DescriptorSetLayout;
    public uint Binding;
}