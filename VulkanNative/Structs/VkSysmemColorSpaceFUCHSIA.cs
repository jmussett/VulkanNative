using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSysmemColorSpaceFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public uint ColorSpace;
}