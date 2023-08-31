using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 transformFeedback;
    public VkBool32 geometryStreams;

    public VkPhysicalDeviceTransformFeedbackFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT;
    }
}