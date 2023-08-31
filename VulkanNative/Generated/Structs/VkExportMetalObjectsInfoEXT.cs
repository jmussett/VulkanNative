using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectsInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
}