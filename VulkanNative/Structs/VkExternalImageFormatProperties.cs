using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalImageFormatProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryProperties externalMemoryProperties;
}