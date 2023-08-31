using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFenceProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
    public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
    public VkExternalFenceFeatureFlags externalFenceFeatures;
}