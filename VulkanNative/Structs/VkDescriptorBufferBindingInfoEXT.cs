using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferBindingInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceAddress Address;
    public VkBufferUsageFlags Usage;
}