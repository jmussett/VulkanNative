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
}