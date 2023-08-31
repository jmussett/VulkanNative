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

    public VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV;
    }
}