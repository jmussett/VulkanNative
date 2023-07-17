using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryProperties
{
    public VkExternalMemoryFeatureFlags externalMemoryFeatures;
    public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
    public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}