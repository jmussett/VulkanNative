using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint DeviceMask;
    public uint DeviceRenderAreaCount;
    public VkRect2D* PDeviceRenderAreas;
}