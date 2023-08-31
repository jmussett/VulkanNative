using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pAttributes;
    public nint dwAccess;
    public nint name;

    public VkExportSemaphoreWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR;
    }
}