using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
    public VkStructureType sType;
    public void* pNext;
    public ulong firstDrawTimestamp;
    public ulong swapBufferTimestamp;
}