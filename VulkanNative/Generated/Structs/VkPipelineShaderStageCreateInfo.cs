using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineShaderStageCreateFlags flags;
    public VkShaderStageFlags stage;
    public VkShaderModule module;
    public byte* pName;
    public VkSpecializationInfo* pSpecializationInfo;
}