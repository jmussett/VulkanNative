using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public ulong DrmFormatModifier;
    public VkSharingMode SharingMode;
    public uint QueueFamilyIndexCount;
    public uint* PQueueFamilyIndices;
}