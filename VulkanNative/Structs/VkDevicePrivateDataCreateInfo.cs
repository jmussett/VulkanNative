using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDevicePrivateDataCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint PrivateDataSlotRequestCount;
}