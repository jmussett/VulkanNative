using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineShaderStageCreateFlags Flags;
    public VkShaderStageFlags Stage;
    public VkShaderModule Module;
    public char* PName;
    public VkSpecializationInfo* PSpecializationInfo;
}