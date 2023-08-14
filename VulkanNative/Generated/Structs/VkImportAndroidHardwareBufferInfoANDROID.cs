using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
    public VkStructureType SType;
    public void* PNext;
    public AHardwareBuffer* Buffer;
}