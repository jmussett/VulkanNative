using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxTransformFeedbackStreams;
    public uint maxTransformFeedbackBuffers;
    public VkDeviceSize maxTransformFeedbackBufferSize;
    public uint maxTransformFeedbackStreamDataSize;
    public uint maxTransformFeedbackBufferDataSize;
    public uint maxTransformFeedbackBufferDataStride;
    public VkBool32 transformFeedbackQueries;
    public VkBool32 transformFeedbackStreamsLinesTriangles;
    public VkBool32 transformFeedbackRasterizationStreamSelect;
    public VkBool32 transformFeedbackDraw;

    public VkPhysicalDeviceTransformFeedbackPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT;
    }
}