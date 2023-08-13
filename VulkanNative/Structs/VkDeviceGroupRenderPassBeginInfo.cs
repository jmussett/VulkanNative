using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceMask;
    public uint deviceRenderAreaCount;
    public VkRect2D* pDeviceRenderAreas;
}