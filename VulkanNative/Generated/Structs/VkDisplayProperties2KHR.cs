using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayProperties2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPropertiesKHR displayProperties;
}