using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineViewportStateCreateFlags flags;
    public uint viewportCount;
    public VkViewport* pViewports;
    public uint scissorCount;
    public VkRect2D* pScissors;
}