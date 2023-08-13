using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPastPresentationTimingGOOGLE
{
    public uint PresentID;
    public ulong DesiredPresentTime;
    public ulong ActualPresentTime;
    public ulong EarliestPresentTime;
    public ulong PresentMargin;
}