using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCapabilityFlagsKHR flags;
    public VkDeviceSize minBitstreamBufferOffsetAlignment;
    public VkDeviceSize minBitstreamBufferSizeAlignment;
    public VkExtent2D pictureAccessGranularity;
    public VkExtent2D minCodedExtent;
    public VkExtent2D maxCodedExtent;
    public uint maxDpbSlots;
    public uint maxActiveReferencePictures;
    public VkExtensionProperties stdHeaderVersion;
}