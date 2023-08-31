using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindVideoSessionMemoryInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryBindIndex;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
    public VkDeviceSize memorySize;

    public VkBindVideoSessionMemoryInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR;
    }
}