using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferCreateFlags Flags;
    public VkBufferUsageFlags Usage;
    public VkExternalMemoryHandleTypeFlags HandleType;
}