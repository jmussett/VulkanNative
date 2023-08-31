using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public AHardwareBuffer* buffer;

    public VkImportAndroidHardwareBufferInfoANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID;
    }
}