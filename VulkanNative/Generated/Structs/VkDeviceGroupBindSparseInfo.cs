using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupBindSparseInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint resourceDeviceIndex;
    public uint memoryDeviceIndex;

    public VkDeviceGroupBindSparseInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO;
    }
}