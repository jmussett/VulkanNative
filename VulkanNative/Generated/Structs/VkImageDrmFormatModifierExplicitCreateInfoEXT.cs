using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public ulong drmFormatModifier;
    public uint drmFormatModifierPlaneCount;
    public VkSubresourceLayout* pPlaneLayouts;
}