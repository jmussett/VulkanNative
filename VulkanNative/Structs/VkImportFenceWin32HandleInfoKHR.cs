using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFence Fence;
    public VkFenceImportFlags Flags;
    public VkExternalFenceHandleTypeFlags HandleType;
    public nint Handle;
    public nint Name;
}