using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureKHR src;
    public VkDeviceOrHostAddressKHR dst;
    public VkCopyAccelerationStructureModeKHR mode;

    public VkCopyAccelerationStructureToMemoryInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR;
    }
}