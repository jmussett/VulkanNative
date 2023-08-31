using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 attachmentFeedbackLoopLayout;

    public VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT;
    }
}