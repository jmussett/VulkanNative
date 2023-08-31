using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public ulong drmFormatModifier;
}