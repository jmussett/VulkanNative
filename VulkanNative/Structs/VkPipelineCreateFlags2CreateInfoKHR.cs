using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreateFlags2CreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreateFlags2KHR Flags;
}