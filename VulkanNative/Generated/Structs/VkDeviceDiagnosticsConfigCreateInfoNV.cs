using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceDiagnosticsConfigFlagsNV flags;

    public VkDeviceDiagnosticsConfigCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV;
    }
}