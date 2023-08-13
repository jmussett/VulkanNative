using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 StorageBuffer16BitAccess;
    public VkBool32 UniformAndStorageBuffer16BitAccess;
    public VkBool32 StoragePushConstant16;
    public VkBool32 StorageInputOutput16;
}