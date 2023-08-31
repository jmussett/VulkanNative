using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
}