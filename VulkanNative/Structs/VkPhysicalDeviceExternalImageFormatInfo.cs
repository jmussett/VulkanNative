using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryHandleTypeFlags HandleType;
}