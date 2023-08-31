using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalTextureInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageAspectFlags plane;
    public MTLTexture_id mtlTexture;
}