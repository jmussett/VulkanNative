using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryZirconHandleInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleType;
    public nint handle;
}