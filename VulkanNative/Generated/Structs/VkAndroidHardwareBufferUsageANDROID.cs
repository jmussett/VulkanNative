using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public ulong androidHardwareBufferUsage;

    public VkAndroidHardwareBufferUsageANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID;
    }
}