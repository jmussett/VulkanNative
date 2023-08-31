using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemoryReportFlagsEXT flags;
    public VkDeviceMemoryReportEventTypeEXT type;
    public ulong memoryObjectId;
    public VkDeviceSize size;
    public VkObjectType objectType;
    public ulong objectHandle;
    public uint heapIndex;

    public VkDeviceMemoryReportCallbackDataEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT;
    }
}