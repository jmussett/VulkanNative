using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindSparseInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreCount;
    public VkSemaphore* pWaitSemaphores;
    public uint bufferBindCount;
    public VkSparseBufferMemoryBindInfo* pBufferBinds;
    public uint imageOpaqueBindCount;
    public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
    public uint imageBindCount;
    public VkSparseImageMemoryBindInfo* pImageBinds;
    public uint signalSemaphoreCount;
    public VkSemaphore* pSignalSemaphores;
}