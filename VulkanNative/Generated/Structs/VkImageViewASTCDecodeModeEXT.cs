using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewASTCDecodeModeEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat decodeMode;

    public VkImageViewASTCDecodeModeEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT;
    }
}