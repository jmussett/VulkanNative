using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkClearAttachment
{
    public VkImageAspectFlags AspectMask;
    public uint ColorAttachment;
    public VkClearValue ClearValue;
}