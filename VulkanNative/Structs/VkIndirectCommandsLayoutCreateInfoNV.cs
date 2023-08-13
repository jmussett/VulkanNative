using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkIndirectCommandsLayoutUsageFlagsNV Flags;
    public VkPipelineBindPoint PipelineBindPoint;
    public uint TokenCount;
    public VkIndirectCommandsLayoutTokenNV* PTokens;
    public uint StreamCount;
    public uint* PStreamStrides;
}