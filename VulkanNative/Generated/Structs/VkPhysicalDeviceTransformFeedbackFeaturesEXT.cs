using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 transformFeedback;
    public VkBool32 geometryStreams;
}