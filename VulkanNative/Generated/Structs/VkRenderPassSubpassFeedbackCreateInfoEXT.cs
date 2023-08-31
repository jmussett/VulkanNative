using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
}