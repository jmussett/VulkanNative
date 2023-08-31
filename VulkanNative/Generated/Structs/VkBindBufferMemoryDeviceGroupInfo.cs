using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceIndexCount;
    public uint* pDeviceIndices;
}