using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPresentScalingFlagsEXT scalingBehavior;
    public VkPresentGravityFlagsEXT presentGravityX;
    public VkPresentGravityFlagsEXT presentGravityY;

    public VkSwapchainPresentScalingCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT;
    }
}