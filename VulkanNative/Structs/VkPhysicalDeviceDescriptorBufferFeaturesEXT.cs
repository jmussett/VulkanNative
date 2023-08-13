using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 DescriptorBuffer;
    public VkBool32 DescriptorBufferCaptureReplay;
    public VkBool32 DescriptorBufferImageLayoutIgnored;
    public VkBool32 DescriptorBufferPushDescriptors;
}