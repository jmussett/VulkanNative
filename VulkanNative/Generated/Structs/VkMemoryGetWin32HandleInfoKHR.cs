using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemory Memory;
    public VkExternalMemoryHandleTypeFlags HandleType;
}