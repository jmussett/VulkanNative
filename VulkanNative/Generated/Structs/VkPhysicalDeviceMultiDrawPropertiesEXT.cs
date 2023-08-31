using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxMultiDrawCount;
}