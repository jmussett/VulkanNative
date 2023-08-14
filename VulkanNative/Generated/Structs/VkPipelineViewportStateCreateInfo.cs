using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineViewportStateCreateFlags Flags;
    public uint ViewportCount;
    public VkViewport* PViewports;
    public uint ScissorCount;
    public VkRect2D* PScissors;
}