using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint PriorityCount;
    public VkQueueGlobalPriorityKHR* Priorities;
}