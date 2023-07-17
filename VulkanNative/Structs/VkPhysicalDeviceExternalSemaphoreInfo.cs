using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalSemaphoreHandleTypeFlagBits handleType;
}