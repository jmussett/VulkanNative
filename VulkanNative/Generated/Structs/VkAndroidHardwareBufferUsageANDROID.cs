using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public ulong androidHardwareBufferUsage;
}