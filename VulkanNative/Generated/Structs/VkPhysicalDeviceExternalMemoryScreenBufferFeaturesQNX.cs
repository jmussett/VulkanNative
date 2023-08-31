using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 screenBufferImport;
}