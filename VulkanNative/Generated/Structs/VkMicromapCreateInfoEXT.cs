using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkMicromapCreateFlagsEXT CreateFlags;
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
    public VkMicromapTypeEXT Type;
    public VkDeviceAddress DeviceAddress;
}