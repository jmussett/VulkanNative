using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageFormatProperties imageFormatProperties;
}