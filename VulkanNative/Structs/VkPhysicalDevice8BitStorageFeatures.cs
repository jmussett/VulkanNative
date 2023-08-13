using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 StorageBuffer8BitAccess;
    public VkBool32 UniformAndStorageBuffer8BitAccess;
    public VkBool32 StoragePushConstant8;
}