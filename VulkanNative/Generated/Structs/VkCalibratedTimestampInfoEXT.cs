using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCalibratedTimestampInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkTimeDomainEXT timeDomain;
}