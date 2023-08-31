using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize robustStorageBufferAccessSizeAlignment;
    public VkDeviceSize robustUniformBufferAccessSizeAlignment;
}