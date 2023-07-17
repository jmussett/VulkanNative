using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalSemaphoreProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
    public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
    public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}