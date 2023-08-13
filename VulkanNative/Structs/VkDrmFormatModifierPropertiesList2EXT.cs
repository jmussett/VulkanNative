using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint DrmFormatModifierCount;
    public VkDrmFormatModifierProperties2EXT* PDrmFormatModifierProperties;
}