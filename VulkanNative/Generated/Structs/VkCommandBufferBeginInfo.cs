using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandBufferUsageFlags flags;
    public VkCommandBufferInheritanceInfo* pInheritanceInfo;

    public VkCommandBufferBeginInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
    }
}