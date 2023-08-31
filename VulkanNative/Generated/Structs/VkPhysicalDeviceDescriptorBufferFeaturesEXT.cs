using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 descriptorBuffer;
    public VkBool32 descriptorBufferCaptureReplay;
    public VkBool32 descriptorBufferImageLayoutIgnored;
    public VkBool32 descriptorBufferPushDescriptors;
}