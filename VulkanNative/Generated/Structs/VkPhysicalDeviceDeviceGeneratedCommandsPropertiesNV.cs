using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxGraphicsShaderGroupCount;
    public uint maxIndirectSequenceCount;
    public uint maxIndirectCommandsTokenCount;
    public uint maxIndirectCommandsStreamCount;
    public uint maxIndirectCommandsTokenOffset;
    public uint maxIndirectCommandsStreamStride;
    public uint minSequencesCountBufferOffsetAlignment;
    public uint minSequencesIndexBufferOffsetAlignment;
    public uint minIndirectCommandsBufferOffsetAlignment;
}