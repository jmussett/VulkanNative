using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemory Memory;
}