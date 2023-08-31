using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoReferenceSlotInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public int slotIndex;
    public VkVideoPictureResourceInfoKHR* pPictureResource;

    public VkVideoReferenceSlotInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR;
    }
}