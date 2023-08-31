using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 provokingVertexLast;
    public VkBool32 transformFeedbackPreservesProvokingVertex;
}