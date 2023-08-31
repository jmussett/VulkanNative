using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderCreateFlagsEXT flags;
    public VkShaderStageFlags stage;
    public VkShaderStageFlags nextStage;
    public VkShaderCodeTypeEXT codeType;
    public nuint codeSize;
    public void* pCode;
    public byte* pName;
    public uint setLayoutCount;
    public VkDescriptorSetLayout* pSetLayouts;
    public uint pushConstantRangeCount;
    public VkPushConstantRange* pPushConstantRanges;
    public VkSpecializationInfo* pSpecializationInfo;

    public VkShaderCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT;
    }
}