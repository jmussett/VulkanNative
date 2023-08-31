using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint queueFamilyIndex;
    public VkVideoSessionCreateFlagsKHR flags;
    public VkVideoProfileInfoKHR* pVideoProfile;
    public VkFormat pictureFormat;
    public VkExtent2D maxCodedExtent;
    public VkFormat referencePictureFormat;
    public uint maxDpbSlots;
    public uint maxActiveReferencePictures;
    public VkExtensionProperties* pStdHeaderVersion;
}