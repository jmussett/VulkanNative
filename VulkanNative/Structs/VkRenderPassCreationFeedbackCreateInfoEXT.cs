using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPassCreationFeedbackInfoEXT* PRenderPassFeedback;
}