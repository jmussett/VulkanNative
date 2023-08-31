using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;

    public VkRenderPassSubpassFeedbackCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT;
    }
}