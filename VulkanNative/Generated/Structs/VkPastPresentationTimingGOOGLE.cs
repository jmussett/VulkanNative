using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPastPresentationTimingGOOGLE
{
    public uint presentID;
    public ulong desiredPresentTime;
    public ulong actualPresentTime;
    public ulong earliestPresentTime;
    public ulong presentMargin;
}