using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imagelessFramebuffer;

    public VkPhysicalDeviceImagelessFramebufferFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES;
    }
}