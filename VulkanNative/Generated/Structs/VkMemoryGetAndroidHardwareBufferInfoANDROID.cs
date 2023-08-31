using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;

    public VkMemoryGetAndroidHardwareBufferInfoANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID;
    }
}