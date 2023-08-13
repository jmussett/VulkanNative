using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalTextureInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
    public VkImageView ImageView;
    public VkBufferView BufferView;
    public VkImageAspectFlags Plane;
    public MTLTexture_id MtlTexture;
}