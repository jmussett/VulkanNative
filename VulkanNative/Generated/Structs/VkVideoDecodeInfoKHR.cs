using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoDecodeFlagsKHR flags;
    public VkBuffer srcBuffer;
    public VkDeviceSize srcBufferOffset;
    public VkDeviceSize srcBufferRange;
    public VkVideoPictureResourceInfoKHR dstPictureResource;
    public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
    public uint referenceSlotCount;
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}