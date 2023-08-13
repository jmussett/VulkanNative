using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyVideoPropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoCodecOperationFlagsKHR VideoCodecOperations;
}