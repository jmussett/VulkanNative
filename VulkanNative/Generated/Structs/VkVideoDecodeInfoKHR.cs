using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoDecodeFlagsKHR Flags;
    public VkBuffer SrcBuffer;
    public VkDeviceSize SrcBufferOffset;
    public VkDeviceSize SrcBufferRange;
    public VkVideoPictureResourceInfoKHR DstPictureResource;
    public VkVideoReferenceSlotInfoKHR* PSetupReferenceSlot;
    public uint ReferenceSlotCount;
    public VkVideoReferenceSlotInfoKHR* PReferenceSlots;
}