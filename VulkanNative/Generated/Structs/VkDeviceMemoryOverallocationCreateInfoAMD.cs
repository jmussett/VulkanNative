using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryOverallocationBehaviorAMD overallocationBehavior;

    public VkDeviceMemoryOverallocationCreateInfoAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD;
    }
}