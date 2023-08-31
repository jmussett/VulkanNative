using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 hostQueryReset;

    public VkPhysicalDeviceHostQueryResetFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES;
    }
}