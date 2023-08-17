using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
    public VkSubpassMergeStatusEXT SubpassMergeStatus;
    public fixed byte Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public uint PostMergeIndex;
}