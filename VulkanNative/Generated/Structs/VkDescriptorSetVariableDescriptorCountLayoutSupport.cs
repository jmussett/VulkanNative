using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxVariableDescriptorCount;

    public VkDescriptorSetVariableDescriptorCountLayoutSupport()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT;
    }
}