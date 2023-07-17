using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorPool descriptorPool;
    public uint descriptorSetCount;
    public VkDescriptorSetLayout* pSetLayouts;
}