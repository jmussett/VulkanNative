using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ProvokingVertexModePerPipeline;
    public VkBool32 TransformFeedbackPreservesTriangleFanProvokingVertex;
}