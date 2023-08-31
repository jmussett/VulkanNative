using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleType;
    public nint fd;

    public VkImportMemoryFdInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR;
    }
}