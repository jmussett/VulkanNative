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
}