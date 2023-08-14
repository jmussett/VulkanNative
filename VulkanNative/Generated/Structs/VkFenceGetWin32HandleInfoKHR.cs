using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFence Fence;
    public VkExternalFenceHandleTypeFlags HandleType;
}