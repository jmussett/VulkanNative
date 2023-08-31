using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 provokingVertexModePerPipeline;
    public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
}