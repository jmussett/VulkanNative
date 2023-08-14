using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreTypeCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphoreType SemaphoreType;
    public ulong InitialValue;
}