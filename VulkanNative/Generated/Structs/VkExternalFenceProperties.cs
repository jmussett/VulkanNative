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

    public VkExternalFenceProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES;
    }
}