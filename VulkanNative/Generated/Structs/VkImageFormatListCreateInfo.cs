using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatListCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint viewFormatCount;
    public VkFormat* pViewFormats;
}