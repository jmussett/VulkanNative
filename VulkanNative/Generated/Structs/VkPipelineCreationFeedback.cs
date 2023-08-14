using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreationFeedback
{
    public VkPipelineCreationFeedbackFlags Flags;
    public ulong Duration;
}