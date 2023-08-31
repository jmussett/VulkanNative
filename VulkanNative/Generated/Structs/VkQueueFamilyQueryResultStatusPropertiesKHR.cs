using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyQueryResultStatusPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 queryResultStatusSupport;

    public VkQueueFamilyQueryResultStatusPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR;
    }
}