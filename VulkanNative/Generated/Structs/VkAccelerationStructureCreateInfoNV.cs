using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize compactedSize;
    public VkAccelerationStructureInfoNV info;

    public VkAccelerationStructureCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV;
    }
}