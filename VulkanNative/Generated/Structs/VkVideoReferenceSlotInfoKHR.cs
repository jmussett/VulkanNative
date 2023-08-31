using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoReferenceSlotInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public int slotIndex;
    public VkVideoPictureResourceInfoKHR* pPictureResource;
}