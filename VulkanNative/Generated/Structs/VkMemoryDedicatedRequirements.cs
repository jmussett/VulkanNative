using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryDedicatedRequirements
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PrefersDedicatedAllocation;
    public VkBool32 RequiresDedicatedAllocation;
}