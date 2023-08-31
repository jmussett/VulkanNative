using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindPipelineIndirectCommandNV
{
    public VkDeviceAddress pipelineAddress;
}