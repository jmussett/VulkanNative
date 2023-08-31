using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxMultiviewViewCount;
    public uint maxMultiviewInstanceIndex;

    public VkPhysicalDeviceMultiviewProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES;
    }
}