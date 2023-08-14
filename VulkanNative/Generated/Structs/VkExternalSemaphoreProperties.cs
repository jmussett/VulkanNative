using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalSemaphoreProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;
    public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;
    public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
}