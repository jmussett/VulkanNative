using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalTextureInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public VkImageView imageView;
    public VkBufferView bufferView;
    public VkImageAspectFlags plane;
    public MTLTexture_id mtlTexture;
}