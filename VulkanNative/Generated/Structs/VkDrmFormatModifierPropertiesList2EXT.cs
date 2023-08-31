using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint drmFormatModifierCount;
    public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
}