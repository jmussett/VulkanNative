using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCapabilitiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoCapabilityFlagsKHR Flags;
    public VkDeviceSize MinBitstreamBufferOffsetAlignment;
    public VkDeviceSize MinBitstreamBufferSizeAlignment;
    public VkExtent2D PictureAccessGranularity;
    public VkExtent2D MinCodedExtent;
    public VkExtent2D MaxCodedExtent;
    public uint MaxDpbSlots;
    public uint MaxActiveReferencePictures;
    public VkExtensionProperties StdHeaderVersion;
}