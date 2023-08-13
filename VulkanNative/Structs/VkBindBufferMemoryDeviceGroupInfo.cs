using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint DeviceIndexCount;
    public uint* PDeviceIndices;
}