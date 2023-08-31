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

    public VkPipelineDiscardRectangleStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT;
    }
}