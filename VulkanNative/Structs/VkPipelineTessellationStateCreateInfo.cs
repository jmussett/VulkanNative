using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineTessellationStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineTessellationStateCreateFlags Flags;
    public uint PatchControlPoints;
}