using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMotionInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxInstances;
    public VkAccelerationStructureMotionInfoFlagsNV flags;

    public VkAccelerationStructureMotionInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV;
    }
}