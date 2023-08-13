using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineDiscardRectangleStateCreateFlagsEXT Flags;
    public VkDiscardRectangleModeEXT DiscardRectangleMode;
    public uint DiscardRectangleCount;
    public VkRect2D* PDiscardRectangles;
}