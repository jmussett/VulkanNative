using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkSparseImageFormatProperties properties;
}