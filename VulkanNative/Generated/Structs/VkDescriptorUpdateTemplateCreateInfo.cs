using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorUpdateTemplateCreateFlags flags;
    public uint descriptorUpdateEntryCount;
    public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
    public VkDescriptorUpdateTemplateType templateType;
    public VkDescriptorSetLayout descriptorSetLayout;
    public VkPipelineBindPoint pipelineBindPoint;
    public VkPipelineLayout pipelineLayout;
    public uint set;

    public VkDescriptorUpdateTemplateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO;
    }
}