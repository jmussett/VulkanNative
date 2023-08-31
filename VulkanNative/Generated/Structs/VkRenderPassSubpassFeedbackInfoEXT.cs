using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
    public VkSubpassMergeStatusEXT subpassMergeStatus;
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public uint postMergeIndex;
}