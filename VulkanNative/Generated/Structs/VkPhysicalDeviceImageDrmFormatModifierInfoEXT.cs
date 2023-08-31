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

    public VkPhysicalDeviceImageDrmFormatModifierInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT;
    }
}