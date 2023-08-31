using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeProperties2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayModePropertiesKHR displayModeProperties;
}