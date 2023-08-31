using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreateFlags2CreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags2KHR flags;
}