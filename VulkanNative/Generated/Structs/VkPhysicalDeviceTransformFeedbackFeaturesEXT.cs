using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 TransformFeedback;
    public VkBool32 GeometryStreams;
}