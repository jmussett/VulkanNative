using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
    public VkDiscardRectangleModeEXT discardRectangleMode;
    public uint discardRectangleCount;
    public VkRect2D* pDiscardRectangles;
}