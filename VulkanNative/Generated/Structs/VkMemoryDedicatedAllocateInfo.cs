using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryDedicatedAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
    public VkBuffer Buffer;
}