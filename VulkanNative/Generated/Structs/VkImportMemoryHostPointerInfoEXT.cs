using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleType;
    public void* pHostPointer;
}