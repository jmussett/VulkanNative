using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryRequirements2
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryRequirements MemoryRequirements;
}