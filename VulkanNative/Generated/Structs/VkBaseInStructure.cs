using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBaseInStructure
{
    public VkStructureType SType;
    public VkBaseInStructure* PNext;
}