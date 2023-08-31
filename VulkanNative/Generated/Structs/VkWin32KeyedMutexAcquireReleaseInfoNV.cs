using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint acquireCount;
    public VkDeviceMemory* pAcquireSyncs;
    public ulong* pAcquireKeys;
    public uint* pAcquireTimeoutMilliseconds;
    public uint releaseCount;
    public VkDeviceMemory* pReleaseSyncs;
    public ulong* pReleaseKeys;

    public VkWin32KeyedMutexAcquireReleaseInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV;
    }
}