using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint DrmFormatModifierCount;
    public VkDrmFormatModifierPropertiesEXT* PDrmFormatModifierProperties;
}