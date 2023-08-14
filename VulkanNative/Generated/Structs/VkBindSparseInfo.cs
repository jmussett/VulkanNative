using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindSparseInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreCount;
    public VkSemaphore* PWaitSemaphores;
    public uint BufferBindCount;
    public VkSparseBufferMemoryBindInfo* PBufferBinds;
    public uint ImageOpaqueBindCount;
    public VkSparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;
    public uint ImageBindCount;
    public VkSparseImageMemoryBindInfo* PImageBinds;
    public uint SignalSemaphoreCount;
    public VkSemaphore* PSignalSemaphores;
}