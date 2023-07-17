using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandBufferUsageFlags flags;
    public VkCommandBufferInheritanceInfo* pInheritanceInfo;
}