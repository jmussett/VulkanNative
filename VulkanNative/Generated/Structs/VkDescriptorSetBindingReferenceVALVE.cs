using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorSetLayout descriptorSetLayout;
    public uint binding;
}