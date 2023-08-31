using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalDeviceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public MTLDevice_id mtlDevice;
}