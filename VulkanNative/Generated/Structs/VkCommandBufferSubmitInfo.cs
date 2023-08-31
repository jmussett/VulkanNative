using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandBuffer commandBuffer;
    public uint deviceMask;

    public VkCommandBufferSubmitInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO;
    }
}