using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 optimalDeviceAccess;
    public VkBool32 identicalMemoryLayout;

    public VkHostImageCopyDevicePerformanceQueryEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT;
    }
}