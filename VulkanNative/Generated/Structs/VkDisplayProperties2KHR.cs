using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayProperties2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayPropertiesKHR DisplayProperties;
}