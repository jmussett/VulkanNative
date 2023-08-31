using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFormatQNX
{
    public VkStructureType sType;
    public void* pNext;
    public ulong externalFormat;

    public VkExternalFormatQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX;
    }
}