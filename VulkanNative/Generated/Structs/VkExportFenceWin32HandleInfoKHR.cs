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
}