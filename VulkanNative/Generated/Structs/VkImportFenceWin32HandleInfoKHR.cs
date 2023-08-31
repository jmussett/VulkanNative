using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkFenceImportFlags flags;
    public VkExternalFenceHandleTypeFlags handleType;
    public nint handle;
    public nint name;
}