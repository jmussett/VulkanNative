using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pAttributes;
    public nint dwAccess;
    public nint name;

    public VkExportFenceWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR;
    }
}