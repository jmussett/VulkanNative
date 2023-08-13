using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBaseOutStructure
{
    public VkStructureType SType;
    public VkBaseOutStructure* PNext;
}