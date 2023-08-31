using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSysmemColorSpaceFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint colorSpace;
}