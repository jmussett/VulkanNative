using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
    public VkStructureType SType;
    public void* PNext;
    public ulong FirstDrawTimestamp;
    public ulong SwapBufferTimestamp;
}