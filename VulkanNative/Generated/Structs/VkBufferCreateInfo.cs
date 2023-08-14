using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferCreateFlags Flags;
    public VkDeviceSize Size;
    public VkBufferUsageFlags Usage;
    public VkSharingMode SharingMode;
    public uint QueueFamilyIndexCount;
    public uint* PQueueFamilyIndices;
}