using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint drmFormatModifierCount;
    public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
}