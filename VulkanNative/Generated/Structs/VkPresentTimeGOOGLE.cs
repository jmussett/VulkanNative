using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentTimeGOOGLE
{
    public uint presentID;
    public ulong desiredPresentTime;
}