using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateFlags flags;
    public VkBufferUsageFlags usage;
    public VkExternalMemoryHandleTypeFlags handleType;

    public VkPhysicalDeviceExternalBufferInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO;
    }
}