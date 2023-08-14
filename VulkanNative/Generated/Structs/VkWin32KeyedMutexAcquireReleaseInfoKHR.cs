using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint AcquireCount;
    public VkDeviceMemory* PAcquireSyncs;
    public ulong* PAcquireKeys;
    public uint* PAcquireTimeouts;
    public uint ReleaseCount;
    public VkDeviceMemory* PReleaseSyncs;
    public ulong* PReleaseKeys;
}