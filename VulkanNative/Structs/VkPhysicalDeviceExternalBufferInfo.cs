using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateFlags flags;
    public VkBufferUsageFlags usage;
    public VkExternalMemoryHandleTypeFlagBits handleType;
}