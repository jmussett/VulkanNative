using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleType;
    public nint handle;
    public nint name;

    public VkImportMemoryWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR;
    }
}