using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyVideoPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCodecOperationFlagsKHR videoCodecOperations;
}