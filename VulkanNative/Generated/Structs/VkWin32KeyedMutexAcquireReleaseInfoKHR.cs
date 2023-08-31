using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint acquireCount;
    public VkDeviceMemory* pAcquireSyncs;
    public ulong* pAcquireKeys;
    public uint* pAcquireTimeouts;
    public uint releaseCount;
    public VkDeviceMemory* pReleaseSyncs;
    public ulong* pReleaseKeys;
}