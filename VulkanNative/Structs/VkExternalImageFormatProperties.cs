using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalImageFormatProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryProperties ExternalMemoryProperties;
}