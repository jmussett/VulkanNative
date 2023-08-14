using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetFdInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFence Fence;
    public VkExternalFenceHandleTypeFlags HandleType;
}