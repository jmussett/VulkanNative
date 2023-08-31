using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 provokingVertexModePerPipeline;
    public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;

    public VkPhysicalDeviceProvokingVertexPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT;
    }
}