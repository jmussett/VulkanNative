using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorSetLayout descriptorSetLayout;
    public uint binding;

    public VkDescriptorSetBindingReferenceVALVE()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE;
    }
}