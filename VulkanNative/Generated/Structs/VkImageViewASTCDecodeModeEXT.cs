using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewASTCDecodeModeEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat DecodeMode;
}