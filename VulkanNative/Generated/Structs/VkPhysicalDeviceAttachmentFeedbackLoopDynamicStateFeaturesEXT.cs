using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 attachmentFeedbackLoopDynamicState;

    public VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT;
    }
}