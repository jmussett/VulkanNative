using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureCreateFlagsKHR createFlags;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkDeviceSize size;
    public VkAccelerationStructureTypeKHR type;
    public VkDeviceAddress deviceAddress;

    public VkAccelerationStructureCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;
    }
}