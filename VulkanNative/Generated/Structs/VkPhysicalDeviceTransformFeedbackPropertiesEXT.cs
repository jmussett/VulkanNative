using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxTransformFeedbackStreams;
    public uint MaxTransformFeedbackBuffers;
    public VkDeviceSize MaxTransformFeedbackBufferSize;
    public uint MaxTransformFeedbackStreamDataSize;
    public uint MaxTransformFeedbackBufferDataSize;
    public uint MaxTransformFeedbackBufferDataStride;
    public VkBool32 TransformFeedbackQueries;
    public VkBool32 TransformFeedbackStreamsLinesTriangles;
    public VkBool32 TransformFeedbackRasterizationStreamSelect;
    public VkBool32 TransformFeedbackDraw;
}