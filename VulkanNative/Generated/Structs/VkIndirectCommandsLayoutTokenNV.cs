using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkIndirectCommandsTokenTypeNV tokenType;
    public uint stream;
    public uint offset;
    public uint vertexBindingUnit;
    public VkBool32 vertexDynamicStride;
    public VkPipelineLayout pushconstantPipelineLayout;
    public VkShaderStageFlags pushconstantShaderStageFlags;
    public uint pushconstantOffset;
    public uint pushconstantSize;
    public VkIndirectStateFlagsNV indirectStateFlags;
    public uint indexTypeCount;
    public VkIndexType* pIndexTypes;
    public uint* pIndexTypeValues;

    public VkIndirectCommandsLayoutTokenNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV;
    }
}