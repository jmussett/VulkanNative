using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorUpdateTemplateCreateFlags Flags;
    public uint DescriptorUpdateEntryCount;
    public VkDescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;
    public VkDescriptorUpdateTemplateType TemplateType;
    public VkDescriptorSetLayout DescriptorSetLayout;
    public VkPipelineBindPoint PipelineBindPoint;
    public VkPipelineLayout PipelineLayout;
    public uint Set;
}