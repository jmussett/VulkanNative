using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentTimesInfoGOOGLE
{
    public VkStructureType SType;
    public void* PNext;
    public uint SwapchainCount;
    public VkPresentTimeGOOGLE* PTimes;
}