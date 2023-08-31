using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCalibratedTimestampInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkTimeDomainEXT timeDomain;

    public VkCalibratedTimestampInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT;
    }
}