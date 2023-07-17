using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormatProperties formatProperties;
}