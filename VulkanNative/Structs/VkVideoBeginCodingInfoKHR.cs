using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBeginCodingInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoBeginCodingFlagsKHR Flags;
    public VkVideoSessionKHR VideoSession;
    public VkVideoSessionParametersKHR VideoSessionParameters;
    public uint ReferenceSlotCount;
    public VkVideoReferenceSlotInfoKHR* PReferenceSlots;
}