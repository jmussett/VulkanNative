using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalTextureInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageAspectFlags Plane;
    public MTLTexture_id MtlTexture;
}