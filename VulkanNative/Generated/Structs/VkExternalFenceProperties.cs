using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFenceProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
    public VkExternalFenceHandleTypeFlags CompatibleHandleTypes;
    public VkExternalFenceFeatureFlags ExternalFenceFeatures;
}