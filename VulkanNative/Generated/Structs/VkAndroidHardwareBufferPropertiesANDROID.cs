using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize allocationSize;
    public uint memoryTypeBits;

    public VkAndroidHardwareBufferPropertiesANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID;
    }
}