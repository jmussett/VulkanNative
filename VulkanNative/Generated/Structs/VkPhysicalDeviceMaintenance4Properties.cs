using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize maxBufferSize;
}