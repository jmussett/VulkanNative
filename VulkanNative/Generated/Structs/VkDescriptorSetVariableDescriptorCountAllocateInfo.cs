using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint descriptorSetCount;
    public uint* pDescriptorCounts;
}