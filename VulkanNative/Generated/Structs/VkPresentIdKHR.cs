using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentIdKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint SwapchainCount;
    public ulong* PPresentIds;
}