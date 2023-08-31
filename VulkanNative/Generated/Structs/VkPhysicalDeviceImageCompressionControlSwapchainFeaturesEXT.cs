using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageCompressionControlSwapchain;

    public VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT;
    }
}