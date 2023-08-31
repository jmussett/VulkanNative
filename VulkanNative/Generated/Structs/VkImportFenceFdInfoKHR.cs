using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkFenceImportFlags flags;
    public VkExternalFenceHandleTypeFlags handleType;
    public nint fd;
}