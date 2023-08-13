using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPresentScalingFlagsEXT ScalingBehavior;
    public VkPresentGravityFlagsEXT PresentGravityX;
    public VkPresentGravityFlagsEXT PresentGravityY;
}