using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkIndirectCommandsTokenTypeNV TokenType;
    public uint Stream;
    public uint Offset;
    public uint VertexBindingUnit;
    public VkBool32 VertexDynamicStride;
    public VkPipelineLayout PushconstantPipelineLayout;
    public VkShaderStageFlags PushconstantShaderStageFlags;
    public uint PushconstantOffset;
    public uint PushconstantSize;
    public VkIndirectStateFlagsNV IndirectStateFlags;
    public uint IndexTypeCount;
    public VkIndexType* PIndexTypes;
    public uint* PIndexTypeValues;
}