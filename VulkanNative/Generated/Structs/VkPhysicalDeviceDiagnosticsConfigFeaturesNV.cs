using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 diagnosticsConfig;

    public VkPhysicalDeviceDiagnosticsConfigFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV;
    }
}