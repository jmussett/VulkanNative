using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalSemaphoreHandleTypeFlags HandleType;
}