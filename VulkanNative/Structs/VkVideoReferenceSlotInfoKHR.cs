using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoReferenceSlotInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public int SlotIndex;
    public VkVideoPictureResourceInfoKHR* PPictureResource;
}