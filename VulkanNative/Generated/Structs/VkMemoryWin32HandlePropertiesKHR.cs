using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;

    public VkMemoryWin32HandlePropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR;
    }
}