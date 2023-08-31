using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 subpassMergeFeedback;

    public VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT;
    }
}