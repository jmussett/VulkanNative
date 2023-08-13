using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public ulong DrmFormatModifier;
    public uint DrmFormatModifierPlaneCount;
    public VkSubresourceLayout* PPlaneLayouts;
}