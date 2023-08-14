using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxGraphicsShaderGroupCount;
    public uint MaxIndirectSequenceCount;
    public uint MaxIndirectCommandsTokenCount;
    public uint MaxIndirectCommandsStreamCount;
    public uint MaxIndirectCommandsTokenOffset;
    public uint MaxIndirectCommandsStreamStride;
    public uint MinSequencesCountBufferOffsetAlignment;
    public uint MinSequencesIndexBufferOffsetAlignment;
    public uint MinIndirectCommandsBufferOffsetAlignment;
}