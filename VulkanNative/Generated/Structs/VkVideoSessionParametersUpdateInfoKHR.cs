using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersUpdateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint UpdateSequenceCount;
}