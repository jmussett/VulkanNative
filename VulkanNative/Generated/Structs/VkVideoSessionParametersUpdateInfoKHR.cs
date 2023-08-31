using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersUpdateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint updateSequenceCount;
}