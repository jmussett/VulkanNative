using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 storageBuffer8BitAccess;
    public VkBool32 uniformAndStorageBuffer8BitAccess;
    public VkBool32 storagePushConstant8;
}