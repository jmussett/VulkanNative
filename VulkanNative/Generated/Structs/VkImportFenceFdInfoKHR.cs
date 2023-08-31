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

    public VkImportFenceFdInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR;
    }
}