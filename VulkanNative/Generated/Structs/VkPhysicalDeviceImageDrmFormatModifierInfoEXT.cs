using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public ulong drmFormatModifier;
    public VkSharingMode sharingMode;
    public uint queueFamilyIndexCount;
    public uint* pQueueFamilyIndices;
}