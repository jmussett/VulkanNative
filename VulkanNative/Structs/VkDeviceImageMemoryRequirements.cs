using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageMemoryRequirements
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCreateInfo* PCreateInfo;
    public VkImageAspectFlags PlaneAspect;
}