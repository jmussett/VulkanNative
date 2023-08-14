using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorAddressInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceAddress Address;
    public VkDeviceSize Range;
    public VkFormat Format;
}