using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceFdInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFence Fence;
    public VkFenceImportFlags Flags;
    public VkExternalFenceHandleTypeFlags HandleType;
    public nint Fd;
}