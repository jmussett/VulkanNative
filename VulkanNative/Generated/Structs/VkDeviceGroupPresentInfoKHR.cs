using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint SwapchainCount;
    public uint* PDeviceMasks;
    public VkDeviceGroupPresentModeFlagsKHR Mode;
}