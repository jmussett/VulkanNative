using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;

    public VkRenderPassCreationFeedbackCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT;
    }
}