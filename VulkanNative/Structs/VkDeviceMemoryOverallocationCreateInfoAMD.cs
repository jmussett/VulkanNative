using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryOverallocationBehaviorAMD OverallocationBehavior;
}