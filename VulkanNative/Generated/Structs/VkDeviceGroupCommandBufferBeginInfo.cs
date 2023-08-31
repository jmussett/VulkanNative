using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceMask;
}