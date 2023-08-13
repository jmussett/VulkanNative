using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPassSubpassFeedbackInfoEXT* PSubpassFeedback;
}