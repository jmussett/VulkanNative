using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pVersionData;

    public VkAccelerationStructureVersionInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR;
    }
}