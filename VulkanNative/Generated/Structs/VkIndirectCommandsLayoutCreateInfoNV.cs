using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkIndirectCommandsLayoutUsageFlagsNV flags;
    public VkPipelineBindPoint pipelineBindPoint;
    public uint tokenCount;
    public VkIndirectCommandsLayoutTokenNV* pTokens;
    public uint streamCount;
    public uint* pStreamStrides;
}