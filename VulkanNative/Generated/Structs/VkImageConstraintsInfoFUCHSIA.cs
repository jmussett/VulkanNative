using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageConstraintsInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint formatConstraintsCount;
    public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
    public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
    public VkImageConstraintsInfoFlagsFUCHSIA flags;

    public VkImageConstraintsInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA;
    }
}