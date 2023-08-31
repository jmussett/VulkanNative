using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceDiagnosticsConfigFlagsNV flags;
}