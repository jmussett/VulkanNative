using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint bindingCount;
    public VkDescriptorBindingFlags* pBindingFlags;

    public VkDescriptorSetLayoutBindingFlagsCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO;
    }
}