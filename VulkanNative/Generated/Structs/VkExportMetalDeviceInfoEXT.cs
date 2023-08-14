using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalDeviceInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public MTLDevice_id MtlDevice;
}