using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineTessellationStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineTessellationStateCreateFlags flags;
    public uint patchControlPoints;
}