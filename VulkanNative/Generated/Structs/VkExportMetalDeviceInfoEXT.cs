using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalDeviceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public MTLDevice_id mtlDevice;

    public VkExportMetalDeviceInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT;
    }
}