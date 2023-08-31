using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint descriptorSetCount;
    public uint* pDescriptorCounts;

    public VkDescriptorSetVariableDescriptorCountAllocateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO;
    }
}