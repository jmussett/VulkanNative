using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeProperties2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayModePropertiesKHR DisplayModeProperties;
}