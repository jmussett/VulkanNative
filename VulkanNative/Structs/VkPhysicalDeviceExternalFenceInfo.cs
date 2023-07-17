using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalFenceHandleTypeFlagBits handleType;
}