using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
    public VkStructureType sType;
    public void* pNext;
    public ulong firstDrawTimestamp;
    public ulong swapBufferTimestamp;

    public VkAmigoProfilingSubmitInfoSEC()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC;
    }
}