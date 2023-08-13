using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint QueueFamilyIndex;
    public VkVideoSessionCreateFlagsKHR Flags;
    public VkVideoProfileInfoKHR* PVideoProfile;
    public VkFormat PictureFormat;
    public VkExtent2D MaxCodedExtent;
    public VkFormat ReferencePictureFormat;
    public uint MaxDpbSlots;
    public uint MaxActiveReferencePictures;
    public VkExtensionProperties* PStdHeaderVersion;
}