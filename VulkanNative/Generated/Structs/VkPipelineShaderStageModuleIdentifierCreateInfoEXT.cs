using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint identifierSize;
    public byte* pIdentifier;

    public VkPipelineShaderStageModuleIdentifierCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT;
    }
}