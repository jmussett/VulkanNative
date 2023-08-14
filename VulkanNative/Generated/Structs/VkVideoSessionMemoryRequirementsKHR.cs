using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionMemoryRequirementsKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryBindIndex;
    public VkMemoryRequirements MemoryRequirements;
}