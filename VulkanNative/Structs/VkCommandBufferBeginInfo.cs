using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferBeginInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkCommandBufferUsageFlags Flags;
    public VkCommandBufferInheritanceInfo* PInheritanceInfo;
}