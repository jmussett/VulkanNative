using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureKHR src;
    public VkAccelerationStructureKHR dst;
    public VkCopyAccelerationStructureModeKHR mode;
}