using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalFenceHandleTypeFlags HandleType;
}