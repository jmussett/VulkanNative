using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentImageInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCreateFlags Flags;
    public VkImageUsageFlags Usage;
    public uint Width;
    public uint Height;
    public uint LayerCount;
    public uint ViewFormatCount;
    public VkFormat* PViewFormats;
}