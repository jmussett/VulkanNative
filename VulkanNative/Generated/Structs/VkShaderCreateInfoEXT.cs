using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderCreateFlagsEXT Flags;
    public VkShaderStageFlags Stage;
    public VkShaderStageFlags NextStage;
    public VkShaderCodeTypeEXT CodeType;
    public nint CodeSize;
    public void* PCode;
    public byte* PName;
    public uint SetLayoutCount;
    public VkDescriptorSetLayout* PSetLayouts;
    public uint PushConstantRangeCount;
    public VkPushConstantRange* PPushConstantRanges;
    public VkSpecializationInfo* PSpecializationInfo;
}