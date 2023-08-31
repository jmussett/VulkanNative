using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFormatANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public ulong externalFormat;

    public VkExternalFormatANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID;
    }
}