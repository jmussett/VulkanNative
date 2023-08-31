using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBeginCodingInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoBeginCodingFlagsKHR flags;
    public VkVideoSessionKHR videoSession;
    public VkVideoSessionParametersKHR videoSessionParameters;
    public uint referenceSlotCount;
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}