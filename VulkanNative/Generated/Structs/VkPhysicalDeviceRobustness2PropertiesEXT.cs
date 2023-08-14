using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize RobustStorageBufferAccessSizeAlignment;
    public VkDeviceSize RobustUniformBufferAccessSizeAlignment;
}