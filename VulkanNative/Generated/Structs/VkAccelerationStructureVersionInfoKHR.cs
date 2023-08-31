using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pVersionData;
}