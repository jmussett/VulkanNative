using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionMemoryRequirementsKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryBindIndex;
    public VkMemoryRequirements memoryRequirements;
}