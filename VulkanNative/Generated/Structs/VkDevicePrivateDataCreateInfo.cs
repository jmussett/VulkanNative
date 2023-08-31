using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDevicePrivateDataCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint privateDataSlotRequestCount;

    public VkDevicePrivateDataCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO;
    }
}