using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceOrHostAddressConstKHR src;
    public VkAccelerationStructureKHR dst;
    public VkCopyAccelerationStructureModeKHR mode;

    public VkCopyMemoryToAccelerationStructureInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR;
    }
}