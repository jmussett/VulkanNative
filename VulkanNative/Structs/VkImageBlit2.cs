using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageBlit2
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageSubresourceLayers SrcSubresource;
    public VkOffset3D* SrcOffsets;
    public VkImageSubresourceLayers DstSubresource;
    public VkOffset3D* DstOffsets;
}