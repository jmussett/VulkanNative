using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryProperties
{
    public VkExternalMemoryFeatureFlags ExternalMemoryFeatures;
    public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
    public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes;
}