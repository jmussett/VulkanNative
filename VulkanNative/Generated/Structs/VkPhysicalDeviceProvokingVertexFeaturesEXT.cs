using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ProvokingVertexLast;
    public VkBool32 TransformFeedbackPreservesProvokingVertex;
}