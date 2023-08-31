using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemoryReportFlagsEXT flags;
    public delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfnUserCallback;
    public void* pUserData;

    public VkDeviceDeviceMemoryReportCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT;
    }
}