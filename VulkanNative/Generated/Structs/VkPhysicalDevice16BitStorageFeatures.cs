using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 storageBuffer16BitAccess;
    public VkBool32 uniformAndStorageBuffer16BitAccess;
    public VkBool32 storagePushConstant16;
    public VkBool32 storageInputOutput16;

    public VkPhysicalDevice16BitStorageFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES;
    }
}