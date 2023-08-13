using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatListCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint ViewFormatCount;
    public VkFormat* PViewFormats;
}