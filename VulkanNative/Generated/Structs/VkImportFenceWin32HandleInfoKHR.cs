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

    public VkImportFenceWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR;
    }
}