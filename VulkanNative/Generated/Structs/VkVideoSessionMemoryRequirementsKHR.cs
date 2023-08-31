using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionMemoryRequirementsKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryBindIndex;
    public VkMemoryRequirements memoryRequirements;

    public VkVideoSessionMemoryRequirementsKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR;
    }
}